﻿using System.ServiceModel;
using PS.Mothership.Core.Common.Dto.Event.Notification;

namespace PS.Mothership.Core.Common.Contracts
{
    [ServiceContract(Name="DiallerTaskNotificationService", CallbackContract = typeof (IDiallerTaskNotificationCallback))]
    public interface IDiallerTaskNotificationService : IQuartzJobBase
    {
        [OperationContract(IsOneWay = false)]
        void Subscribe(string applicationName);

        [OperationContract(IsOneWay = true)]
        void EndSubscribe(string applicationName);

        [OperationContract]
        void AddNewTask(NotificationDto taskDto);

        [OperationContract]
        void UpdateTask(NotificationDto taskDto);

        [OperationContract]
        void CompleteTask(long pendingNotificationId);

        [OperationContract]
        void PushPendingTaskNotifications(string userName);
    }
}
