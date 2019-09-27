using System;
using Xamarin.Forms;

namespace CreateNew.Selector
{
    /// <summary>
    /// テンプレートセレクタ
    /// </summary>
    public class OrderTemplateSelector : DataTemplateSelector
    {
        public DataTemplate InjectionTemplate { get; set; }
        public DataTemplate DealTemplate { get; set; }
        public DataTemplate OtherTemplate { get; set; }

        public OrderTemplateSelector() 
        {
        }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            throw new NotImplementedException();
        }
    }
}
