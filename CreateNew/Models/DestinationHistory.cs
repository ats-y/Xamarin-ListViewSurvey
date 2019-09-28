using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace CreateNew.Models
{
    /// <summary>
    /// 行き先履歴
    /// </summary>
    public class DestinationHistory : INotifyPropertyChanged
    {
        /// <summary>
        /// 履歴タイトル
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 履歴行の背景色
        /// </summary>
        public Color CBColor { get; set; }

        public DestinationHistory()
        {
        }

        /// <summary>
        /// プロパティ変化イベント。
        /// INotifyPropertyChangedの実装。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 履歴行の背景色を変更する。
        /// </summary>
        public void ChangeBackColor()
        {
            // 背景色変更。
            CBColor = Color.FromRgb(0xA3, 0xC9, 0xA8);

            // プロパティが変化したことを伝える。
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CBColor)));
        }
    }
}
