using System;
using System.Collections.ObjectModel;

namespace Common.Library
{
  public class ViewModelBase : CommonBase
  {

      #region AddBusinessRuleMessage Method
    public virtual void AddValidationMessage(string propertyName, string msg)
    {
    }
    #endregion

    #region Clear Method
    public virtual void Clear()
    {
    }
    #endregion

    #region DisplayStatusMessage Method
    public virtual void DisplayStatusMessage(string msg = "")
    {
      MessageBroker.Instance.SendMessage(MessageBrokerMessages.DISPLAY_STATUS_MESSAGE, msg);
    }
    #endregion

    #region PublishException Method
    public void PublishException(Exception ex)
    {
      // Publish Exception
      ExceptionManager.Instance.Publish(ex);
    }
    #endregion

    #region Close Method
    public virtual void Close(bool wasCancelled = true)
    {
      MessageBroker.Instance.SendMessage(MessageBrokerMessages.CLOSE_USER_CONTROL, wasCancelled);
    }
    #endregion

    #region Dispose Method
    public virtual void Dispose()
    {
    }
    #endregion
  }
}
