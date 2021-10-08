using ConsoleQuest.common.enumerated;

namespace ConsoleQuest.entity
{
	public class StatusEntity
	{
		public string name { get; set; }
		public int enemy { get; set; }
		public int maxhp { get; set; }
		public int hp { get; set; }
		public int mp { get; set; }
		public int ap { get; set; }
		public int pp { get; set; }
		public int sp { get; set; }
		public int gold { get; set; }
		public int exp { get; set; }
		public string area { get; set; }
		public BattleActionEnum action { get; set; }
	}
}
