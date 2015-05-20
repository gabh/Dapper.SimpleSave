using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Dapper.SimpleSave.Impl
{
    public class PropertyMetadata : BaseMetadata
    {

        public PropertyInfo Prop { get; set; }

        public PropertyMetadata(PropertyInfo prop) : base(prop)
        {
            Prop = prop;

            InitEnumerable();
            InitValueType();
            InitEnum();
            InitBool();
            InitDateTime();
            InitDateTimeOffset();
            InitNumericType();
            InitReferenceType();
        }

        public bool IsPrimaryKey
        {
            get { return HasAttribute<PrimaryKeyAttribute>();}
        }

        public bool IsManyToManyRelationship
        {
            get { return HasAttribute<ManyToManyAttribute>(); }
        }

        public bool IsOneToManyRelationship
        {
            get { return HasAttribute<OneToManyAttribute>(); }
        }

        public bool IsReadOnly
        {
            get { return HasAttribute<ReadOnlyAttribute>() || ! Prop.CanWrite;}
        }

        public bool IsPublic
        {
            get { return Prop.GetGetMethod().IsPublic; }
        }

        public bool IsSaveable
        {
            get { return !IsReadOnly && IsPublic; }
        }

        public bool IsEnumerable { get; private set; }

        public bool IsEnum { get; private set; }

        public bool IsBool { get; private set; }

        public bool IsValueType { get; private set; }

        public bool IsNumericType { get; private set; }

        public bool IsDateTime { get; private set; }

        public bool IsDateTimeOffset { get; private set; }

        public bool IsReferenceType { get; private set; }

        public object GetValue(object source)
        {
            return Prop.GetGetMethod().Invoke(source, new object[0]);
        }

        private void InitEnumerable()
        {
            IsEnumerable = Prop.PropertyType.IsEnumerable();
        }

        private void InitValueType()
        {
            IsValueType = Prop.PropertyType.IsValueType;
        }

        private void InitEnum()
        {
            IsValueType = Prop.PropertyType.IsEnum;
        }

        private void InitBool()
        {
            IsBool = typeof (bool) == Prop.PropertyType;
        }

        private void InitDateTime()
        {
            IsDateTime = typeof (DateTime) == Prop.PropertyType;
        }

        private void InitDateTimeOffset()
        {
            IsDateTimeOffset = typeof (DateTimeOffset) == Prop.PropertyType;
        }
        private void InitNumericType()
        {
            IsNumericType = IsValueType && !(IsEnumerable || IsBool || IsDateTime || IsDateTimeOffset);
        }

        private void InitReferenceType()
        {
            IsReferenceType = Prop.PropertyType.IsClass || Prop.PropertyType.IsInterface;
        }
    }
}