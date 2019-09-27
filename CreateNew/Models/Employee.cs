using System;
using System.ComponentModel;
using System.Diagnostics;
using Xamarin.Forms;

namespace CreateNew.Models
{
    /// <summary>
    /// 社員クラス
    /// </summary>
    /// <remarks>
    /// ListViewなどにプロパティ変更を伝えるためINotifyPropertyChangedを実装。
    /// </remarks>
    public class Employee : INotifyPropertyChanged
    {
        /// <summary>
        /// 名前
        /// </summary>
        public string DispName { get; }

        /// <summary>
        /// 行き先（編集前）
        /// </summary>
        public EDestination OrgDestination { get; }

        /// <summary>
        /// 行き先（編集可能）
        /// </summary>
        public EDestination Destination { get; set; }

        /// <summary>
        /// 行き先表示文字列
        /// </summary>
        public string DispDestination {
            get
            {
                string result;
                switch (Destination)
                {
                    case EDestination.ReturnHome:
                        result = "帰宅";
                        break;
                    case EDestination.InOffice:
                        result = "自席";
                        break;
                    case EDestination.GoOut:
                        result = "外出";
                        break;
                    default:
                        result = "不明";
                        break;
                }
                return result;
            }
        }

        /// <summary>
        /// 行き先列挙値
        /// </summary>
        public enum EDestination
        {
            /// <summary>
            /// 帰宅
            /// </summary>
            ReturnHome,

            /// <summary>
            /// 出社
            /// </summary>
            InOffice,

            /// <summary>
            /// 外出
            /// </summary>
            GoOut,

            /// <summary>
            /// 不明
            /// </summary>
            Unknown,
        }

        /// <summary>
        /// 背景色
        /// </summary>
        public Color BackColor {
            get {

                // 行き先が編集前後の状態で色を帰る。
                if (OrgDestination != Destination)
                {
                    // 編集前後で行き先が違う。
                    return Color.FromRgb(0xA3, 0xC9, 0xA8);
                }

                // 行き先が編集前後で同じ。
                return Color.FromRgb(0xDD, 0xD8, 0xC4);
            }
        }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Employee(string name, EDestination dest)
        {
            DispName = name;
            Destination = dest;
            OrgDestination = dest;
        }

        /// <summary>
        /// プロパティ変更イベント。INotifyPropertyChangedの実装。
        /// 本クラスのプロパティが変更されたことを通知する。
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 行き先をじゅんぐり変える
        /// </summary>
        public void ChangeDestination()
        {
            // じゅんぐり変える。
            EDestination now = Destination;
            now += 1;
            if((int)now >= Enum.GetValues(typeof(EDestination)).GetLength(0))
            {
                now = 0;
            }
            Destination = now;

            // 行き先と背景色が変わることを通知する。
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DispDestination)));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(BackColor)));
        }
    }
}
