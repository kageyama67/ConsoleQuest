using System.Collections.Generic;

namespace ConsoleQuest.common.enumerated
{

    /**
     * <summary>
     * 全コマンドを管理するenumクラス
     *   スキルを追加した際はCommandEnumとBattleActionEnum両方に追加が必要
     *   コマンドを追加した場合、追加コマンドに対応する全てのDictijonary設定の追加が必要
     * </summary>
     */
    public enum CommandEnum
    {
        // フィールドコマンド
        Battle,
        Town,
        Move,

        // 街コマンド
        SkillShop,
        Yadoya,

        // バトルコマンド
        Attack,
        Skill,
        Guard,

        // エリアコマンド
        Alliahan,
        Rebe,

        // スキルコマンド
        Hoimi,
        Mera,
        Kialy,
        Merami,
        Behoimi,

        // Yes/Noコマンド
        Yes,
        No,

        // Common
        Param,
        Exit,

    }
    public static class CommandEnumExt
    {
        /**
         * <summary>
         * コマンド種別を取得する
         * </summary>
         * 
         * <param name="CommandEnum"></param>
         * <returns>指定されたCommandEnumに対応する種別</returns>
         */
        public static CommandTypeEnum GetCommandType(this CommandEnum state)
        {
            return CommandTypeDictionary[state];
        }
        /**
         * <summary>
         * コマンド種別を設定
         * </summary>
         */
        private static Dictionary<CommandEnum, CommandTypeEnum> CommandTypeDictionary = new Dictionary<CommandEnum, CommandTypeEnum>()
        {
            // フィールドコマンド
            {CommandEnum.Battle,        CommandTypeEnum.Field },
            {CommandEnum.Town,          CommandTypeEnum.Field },
            {CommandEnum.Move,          CommandTypeEnum.Field },

            // 街コマンド
            {CommandEnum.SkillShop,     CommandTypeEnum.Town },
            {CommandEnum.Yadoya,        CommandTypeEnum.Town },

            // バトルコマンド
            {CommandEnum.Attack,        CommandTypeEnum.Battle },
            {CommandEnum.Skill,         CommandTypeEnum.Battle },
            {CommandEnum.Guard,         CommandTypeEnum.Battle },

            // エリアコマンド
            {CommandEnum.Alliahan,      CommandTypeEnum.Area },
            {CommandEnum.Rebe,          CommandTypeEnum.Area },

            // スキルコマンド
            {CommandEnum.Hoimi,         CommandTypeEnum.Skill },
            {CommandEnum.Mera,          CommandTypeEnum.Skill },
            {CommandEnum.Kialy,         CommandTypeEnum.Skill },
            {CommandEnum.Merami,        CommandTypeEnum.Skill },
            {CommandEnum.Behoimi,       CommandTypeEnum.Skill },

            // Yes/Noコマンド
            {CommandEnum.Yes,           CommandTypeEnum.YesNo },
            {CommandEnum.No,            CommandTypeEnum.YesNo },

            // Common
            {CommandEnum.Param,         CommandTypeEnum.Common },
            {CommandEnum.Exit,          CommandTypeEnum.Common },

        };
        /**
         * <summary>
         * コマンドキーを取得する
         * </summary>
         * 
         * <param name="CommandEnum"></param>
         * <returns>指定されたCommandEnumに対応するコマンド名</returns>
         */
        public static string GetCommandKey(this CommandEnum state)
        {
            return CommandKeyDictionary[state];
        }
        /**
         * <summary>
         * CommandEnumに対応するコマンド名を設定
         * 実際に入力するコマンド名を設定する。
         * 運用としてコマンド名は1意に設定すること。
         * (1意にしなくてもシステム上はエラーとならないので注意!!!)
         * </summary>
         */
        private static Dictionary<CommandEnum, string> CommandKeyDictionary = new Dictionary<CommandEnum, string>()
        {
            // フィールドコマンド
            {CommandEnum.Battle,        "battle" },
            {CommandEnum.Town,          "town" },
            {CommandEnum.Move,          "move" },

            // 街コマンド
            {CommandEnum.SkillShop,     "skill" },
            {CommandEnum.Yadoya,        "yadoya" },

            // バトルコマンド
            {CommandEnum.Attack,        "attack" },
            {CommandEnum.Skill,         "skill" },
            {CommandEnum.Guard,         "guard" },

            // エリアコマンド
            {CommandEnum.Alliahan,      "alliahan" },
            {CommandEnum.Rebe,          "rebe" },

            // スキルコマンド
            {CommandEnum.Hoimi,         "hoimi" },
            {CommandEnum.Mera,          "mera" },
            {CommandEnum.Kialy,         "kialy" },
            {CommandEnum.Merami,        "merami" },
            {CommandEnum.Behoimi,       "behoimi" },

            // Yes/Noコマンド
            {CommandEnum.Yes,           "yes" },
            {CommandEnum.No,            "no" },

            // Common
            {CommandEnum.Param,         "param" },
            {CommandEnum.Exit,          "exit" },

        };
        /**
         * <summary>
         * コマンド値1を取得する
         * </summary>
         * 
         * <param name="CommandEnum"></param>
         * <returns>指定されたCommandEnumに対応するコマンド名</returns>
         */
        public static string GetCommandValue1(this CommandEnum state)
        {
            return CommandValue1Dictionary[state];
        }
        /**
         * <summary>
         * CommandEnumに対応するコマンド値1を設定
         * 全角文字で設定すること。じゃないとコマンド表示がずれる。
         * </summary>
         */
        private static Dictionary<CommandEnum, string> CommandValue1Dictionary = new Dictionary<CommandEnum, string>()
        {

            // フィールドコマンド
            {CommandEnum.Battle,        "バトルする" },
            {CommandEnum.Town,          "街に行く" },
            {CommandEnum.Move,          "移動する" },

            // 街コマンド
            {CommandEnum.SkillShop,     "スキルショップ" },
            {CommandEnum.Yadoya,        "宿屋" },

            // バトルコマンド
            {CommandEnum.Attack,         "攻撃" },
            {CommandEnum.Skill,          "スキル" },
            {CommandEnum.Guard,          "防御" },

            // エリアコマンド
            {CommandEnum.Alliahan,      "アリアハン" },
            {CommandEnum.Rebe,          "レーベ" },

            // スキルコマンド
            {CommandEnum.Hoimi,         "ホイミ" },
            {CommandEnum.Mera,          "メラ" },
            {CommandEnum.Kialy,         "キアリー" },
            {CommandEnum.Merami,        "メラミ" },
            {CommandEnum.Behoimi,       "ベホイミ" },

            // Yes/Noコマンド
            {CommandEnum.Yes,           "" },
            {CommandEnum.No,            "" },

            // Common
            {CommandEnum.Param,         "パラメータ表示" },
            {CommandEnum.Exit,          "" },

        };
        /**
         * <summary>
         * コマンド値2を取得する
         * </summary>
         * 
         * <param name="CommandEnum"></param>
         * <returns>指定されたCommandEnumに対応するコマンド名</returns>
         */
        public static string GetCommandValue2(this CommandEnum state)
        {
            return CommandValue2Dictionary[state];
        }
        /**
         * <summary>
         * CommandEnumに対応するコマンド値2を設定
         * </summary>
         */
        private static Dictionary<CommandEnum, string> CommandValue2Dictionary = new Dictionary<CommandEnum, string>()
        {

            // フィールドコマンド
            {CommandEnum.Battle,        "" },
            {CommandEnum.Town,          "" },
            {CommandEnum.Move,          "" },

            // 街コマンド
            {CommandEnum.SkillShop,     "" },
            {CommandEnum.Yadoya,        "10" },

            // バトルコマンド
            {CommandEnum.Attack,         "" },
            {CommandEnum.Skill,          "" },
            {CommandEnum.Guard,          "" },
            //{CommandEnum.Escape,         "" },

            // エリアコマンド
            {CommandEnum.Alliahan,      "" },
            {CommandEnum.Rebe,          "" },

            // スキルコマンド
            {CommandEnum.Hoimi,         "alliahan" },
            {CommandEnum.Mera,          "alliahan,rebe" },
            {CommandEnum.Kialy,         "alliahan,rebe" },
            {CommandEnum.Merami,        "rebe" },
            {CommandEnum.Behoimi,       "rebe" },

            // Yes/Noコマンド
            {CommandEnum.Yes,           "" },
            {CommandEnum.No,            "" },

            // Common
            {CommandEnum.Param,         "" },
            {CommandEnum.Exit,          "" },

        };

        /**
         * <summary>
         * コマンド値3を取得する
         * </summary>
         * 
         * <param name="CommandEnum"></param>
         * <returns>指定されたCommandEnumに対応するコマンド名</returns>
         */
        public static string GetCommandValue3(this CommandEnum state)
        {
            return CommandValue3Dictionary[state];
        }
        /**
         * <summary>
         * CommandEnumに対応するコマンド値3を設定
         * </summary>
         */
        private static Dictionary<CommandEnum, string> CommandValue3Dictionary = new Dictionary<CommandEnum, string>()
        {

            // フィールドコマンド
            {CommandEnum.Battle,        "" },
            {CommandEnum.Town,          "" },
            {CommandEnum.Move,          "" },

            // 街コマンド
            {CommandEnum.SkillShop,     "" },
            {CommandEnum.Yadoya,        "10" },

            // バトルコマンド
            {CommandEnum.Attack,         "0" },
            {CommandEnum.Skill,          "0" },
            {CommandEnum.Guard,          "0" },
            //{CommandEnum.Escape,         "0" },

            // エリアコマンド
            {CommandEnum.Alliahan,      "" },
            {CommandEnum.Rebe,          "" },

            // スキルコマンド
            {CommandEnum.Hoimi,         "30" },
            {CommandEnum.Mera,          "30" },
            {CommandEnum.Kialy,         "50" },
            {CommandEnum.Merami,        "70" },
            {CommandEnum.Behoimi,       "70" },

            // Yes/Noコマンド
            {CommandEnum.Yes,           "" },
            {CommandEnum.No,            "" },

            // Common
            {CommandEnum.Param,         "" },
            {CommandEnum.Exit,          "" },

        };
    }
}
