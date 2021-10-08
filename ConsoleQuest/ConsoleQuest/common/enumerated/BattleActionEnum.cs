using System.Collections.Generic;

namespace ConsoleQuest.common.enumerated
{

    /**
     * <summary>
     * コマンドリストを設定するEnumクラス
     *   スキルを追加した際はCommandEnumとBattleActionEnumに追加する
     * </summary>
     * 
     */
    public enum BattleActionEnum
    {
        // 通常攻撃
        NormalAttack,
        // スマッシュ攻撃（守備力無視）
        SmashAttack,
        // 防御
        Guard,
        // 逃亡
        MonsterEscape,
        // 回復スキル（ホイミ）
        Hoimi,
        // 攻撃スキル（メラ）
        Mera,
        // 攻撃スキル（メラミ）
        Merami,
        // 回復スキル（ベホイミ）
        Behoimi,
        // 補助スキル（キアリー）[未実装：毒ステータスの解除]
        Kialy,
        // キャンセル
        Cancel,
        // なし
        None,
    }

    public static class BattleActionEnumExt
    {
        /**
         * <summary>
         * ワード1を取得する
         * </summary>
         * 
         * <param name="BattleActionEnum"></param>
         * <returns>指定されたBattleActionEnumに対応する種別</returns>
         */
        public static string GetBattleActionWord1(this BattleActionEnum state)
        {
            return BattleActionWord1Dictionary[state];
        }
        /**
         * <summary>
         * ワード2を取得する
         * </summary>
         * 
         * <param name="BattleActionEnum"></param>
         * <returns>指定されたBattleActionEnumに対応するコマンド名</returns>
         */
        public static string GetBattleActionWord2(this BattleActionEnum state)
        {
            return BattleActionWord2Dictionary[state];
        }
        /**
         * <summary>
         * スキル実行に必要なMPを取得する
         * </summary>
         * 
         * <param name="BattleActionEnum"></param>
         * <returns>指定されたBattleActionEnumに対応する種別</returns>
         */
        public static int GetBattleActionMp(this BattleActionEnum state)
        {
            return BattleActionMpDictionary[state];
        }
        /**
         * <summary>
         * スキル固有のValueを取得する
         * </summary>
         * 
         * <param name="BattleActionEnum"></param>
         * <returns>指定されたBattleActionEnumに対応する種別</returns>
         */
        public static int GetBattleActionValue(this BattleActionEnum state)
        {
            return BattleActionValueDictionary[state];
        }

        /**
         * <summary>
         * ワード1を設定
         * </summary>
         */
        private static Dictionary<BattleActionEnum, string> BattleActionWord1Dictionary = new Dictionary<BattleActionEnum, string>()
        {
            {BattleActionEnum.NormalAttack,       "の攻撃! " },
            {BattleActionEnum.SmashAttack,        "" },
            {BattleActionEnum.Guard,              "は身をまもっている。" },
            {BattleActionEnum.MonsterEscape,      "" },
            {BattleActionEnum.Hoimi,              "はホイミをとなえた" },
            {BattleActionEnum.Mera,               "はメラをとなえた。" },
            {BattleActionEnum.Merami,             "はメラミをとなえた。" },
            {BattleActionEnum.Behoimi,            "はベホイミをとなえた。" },
            {BattleActionEnum.Kialy,              "はキアリーをとなえた。" },
            {BattleActionEnum.Cancel,             "" },
            {BattleActionEnum.None,               "" },
        };
        /**
         * <summary>
         * ワード2を設定
         * </summary>
         */
        private static Dictionary<BattleActionEnum, string> BattleActionWord2Dictionary = new Dictionary<BattleActionEnum, string>()
        {
            {BattleActionEnum.NormalAttack,       "" },
            {BattleActionEnum.SmashAttack,        "" },
            {BattleActionEnum.Guard,              "" },
            {BattleActionEnum.MonsterEscape,      "" },
            {BattleActionEnum.Hoimi,              "の傷が回復した。" },
            {BattleActionEnum.Mera,               "" },
            {BattleActionEnum.Merami,             "" },
            {BattleActionEnum.Behoimi,            "の傷が回復した。" },
            {BattleActionEnum.Kialy,              "の体から毒が消えた。" },
            {BattleActionEnum.Cancel,             "" },
            {BattleActionEnum.None,               "" },
        };

        /**
         * <summary>
         * スキル実行に必要なMPを設定
         * </summary>
         */
        private static Dictionary<BattleActionEnum, int> BattleActionMpDictionary = new Dictionary<BattleActionEnum, int>()
        {
            {BattleActionEnum.NormalAttack,       0 },
            {BattleActionEnum.SmashAttack,        0 },
            {BattleActionEnum.Guard,              0 },
            {BattleActionEnum.MonsterEscape,      0 },
            {BattleActionEnum.Hoimi,              3 },
            {BattleActionEnum.Mera,               2 },
            {BattleActionEnum.Merami,             5 },
            {BattleActionEnum.Behoimi,            5 },
            {BattleActionEnum.Kialy,              2 },
            {BattleActionEnum.Cancel,             0 },
            {BattleActionEnum.None,               0 },
        };
        /**
         * <summary>
         * スキル固有のValueを設定
         * </summary>
         */
        private static Dictionary<BattleActionEnum, int> BattleActionValueDictionary = new Dictionary<BattleActionEnum, int>()
        {
            {BattleActionEnum.NormalAttack,       0 },
            {BattleActionEnum.SmashAttack,        3 },
            {BattleActionEnum.Guard,              3 },
            {BattleActionEnum.MonsterEscape,      0 },
            {BattleActionEnum.Hoimi,              30 },
            {BattleActionEnum.Mera,               12 },
            {BattleActionEnum.Merami,             60 },
            {BattleActionEnum.Behoimi,            60 },
            {BattleActionEnum.Kialy,              0 },
            {BattleActionEnum.Cancel,             0 },
            {BattleActionEnum.None,               0 },
        };
    }
}
