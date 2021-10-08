namespace ConsoleQuest.common
{
	/**
	 * <summary>
	 * メッセージ情報を提供するクラスです。
	 * </summary>
	 *
	 */
	public class Messages
	{

		public static string CMDG0001I = "CMDG0001I: コマンドゲームを起動します。";
		public static string CMDG0002I = "CMDG0002I: コマンドゲームを終了します。";
		public static string CMDG0003I = "CMDG0003I: コマンド「 {0} 」を選択。";
		public static string CMDG0004I = "CMDG0004I: 対応する処理が実装されていません。";

		public static string CMDG0001E = "CMDG0001E: エラー発生!!\n{0}";
		public static string CMDG0099E = "{0}{1}";

		/**
		 * <summary>
		 * フォーマットしたメッセージを返却する
		 * </summary>
		 *
         * <param name="msg">メッセージ</param>
         * <param name="args">保管文字列配列</param>
         * <returns>フォーマットされたメッセージ</returns>
		 */
		public static string GetMessage(string msg, params string[] args)
		{
            try
            {
                return string.Format(msg, args);
            }
            catch
            {
                return msg;
            }
        }
	}
}
