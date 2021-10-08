namespace ConsoleQuest.common
{
	/**
     * <summary>
     * 定数クラス
     * </summary>
     */
	public class Constants
	{
		// JSONファイル・プレイヤー
		public const string JsoFilePathPlayer = "C:/temp/ConsoleQuest/player.json";

		// JSONファイル・レベル
		public const string JsonFilePathLevel = "C:/temp/ConsoleQuest/level.json";

		// JSONファイル・モンスター
		public const string JsonFilePathMonster = "C:/temp/ConsoleQuest/monster.json";

		// ログファイル
		public const string LogFilePath = "C:/temp/ConsoleQuest/log/";

		// バトル調整数値
		public const double BattleAjustPercentage = 0.20;

		// 消費MPゼロ
		public static int MpZero = 0;

		// コマンド表示幅 (コマンドを含めたからコマンド説明開始点までの幅)
		public static int CommandWidthFromKeyToDescription = 15;

		// コマンド表示幅 (コマンド説明から金額終端までの幅)
		public static int CommandWidthFromDescriptionToPrice = 20;
	}
}
