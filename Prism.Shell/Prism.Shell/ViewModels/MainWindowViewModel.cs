using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Prism.Shell.ViewModels
{
    internal class MainWindowViewModel : BindableBase
    {
        public string Title => "Prism学习";

        private string keyword=string.Empty;

        public string Keyword
        {
            get { return keyword; }
            set { keyword = value;RaisePropertyChanged(); }
        }


        private DateTime getContentTime;
        /// <summary>
        /// 获取主题的时间
        /// </summary>
        public DateTime GetContentTime
        {
            get { return getContentTime; }
            set { getContentTime = value; RaisePropertyChanged(); }
        }


        public DelegateCommand GetContentCommand => new DelegateCommand(() =>
        {
            System.Diagnostics.Process.Start("http://www.baidu.com");
            GetContentTime = DateTime.Now;
        });

        public DelegateCommand TextBlockMouseUpToCommand => new DelegateCommand(() =>
        {
            MessageBox.Show("你单击了我！");
        });

        /// <summary>
        /// 带参数的Cammand
        /// </summary>
        public DelegateCommand<TextBlock> TextBlockParameterCommand => new DelegateCommand<TextBlock>((textBlock) =>
        {
            MessageBox.Show($"{textBlock.Text}");
        });

        public DelegateCommand SearchCommand => new DelegateCommand(() =>
        {
            MessageBox.Show($"你要搜索的关键词:{Keyword}");
        });
    }
}
