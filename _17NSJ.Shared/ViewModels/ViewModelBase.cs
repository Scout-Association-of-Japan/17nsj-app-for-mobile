using System;
using _17NSJ.Models;

namespace _17NSJ.ViewModels
{
    public class ViewModelBase : NotificationObject
    {
        /// <summary>
        /// ユーザーID
        /// </summary>
        private string userId;

        /// <summary>
        /// 表示名
        /// </summary>
        private string displayName;

        /// <summary>
        /// アクセストークン
        /// </summary>
        private string accessToken;

        /// <summary>
        /// 処理中かどうか
        /// </summary>
        private bool isBusy;

        /// <summary>
        /// ユーザーIDを取得または設定します。
        /// </summary>
        /// <value>ユーザーID</value>
        public string UserId
        {
            get
            {
                return this.userId;
            }

            set
            {
                if (this.userId != value)
                {
                    this.userId = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        /// 表示名を取得または設定します。
        /// </summary>
        /// <value>表示名</value>
        public string DisplayName
        {
            get
            {
                return this.displayName;
            }

            set
            {
                if (this.displayName != value)
                {
                    this.displayName = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        /// アクセストークンを取得または設定します。
        /// </summary>
        /// <value>アクセストークン</value>
        public string AccessToken
        {
            get
            {
                return this.accessToken;
            }

            set
            {
                if (this.accessToken != value)
                {
                    this.accessToken = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        /// 処理中かどうかを取得または設定します。
        /// </summary>
        /// <value>処理中かどうか</value>
        public bool IsBusy
        {
            get
            {
                return this.isBusy;
            }

            set
            {
                if (this.isBusy != value)
                {
                    this.isBusy = value;
                    this.RaisePropertyChanged();
                }
            }
        }
    }
}
