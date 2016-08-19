using Windows.Data.Xml.Dom;
using Windows.UI.Notifications;

namespace UWP_Test {
    /// <summary>
    /// 可以输入文本的通知💬
    /// 输入的内容通过App.OnActivated反馈
    /// </summary>
    class ToastInput {
        private string xml = @"<toast>
    <visual version=""2"">
        <binding template=""ToastText02"">
            <text id=""2"">输入文本：</text>
        </binding>
    </visual>
    <actions>
        <input id=""message"" type=""text""/>
        <action activationType=""foreground"" content=""确定"" arguments=""ok""/>
    </actions>
</toast>";
        public void display() {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            ToastNotification toast = new ToastNotification(doc);
            ToastNotifier notifier = ToastNotificationManager.CreateToastNotifier();
            notifier.Show(toast);
        }
    }
}
