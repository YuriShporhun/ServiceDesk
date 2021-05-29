using System.Windows;
using System.Windows.Controls;

namespace ServiceDesk.Controls
{
    public class ServiceDeskInfoPanel : HeaderedContentControl
    {
        static ServiceDeskInfoPanel()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ServiceDeskInfoPanel), new FrameworkPropertyMetadata(typeof(ServiceDeskInfoPanel)));
        }
    }
}
