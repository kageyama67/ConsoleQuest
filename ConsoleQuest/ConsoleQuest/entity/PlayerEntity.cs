using System.Collections.Generic;

namespace ConsoleQuest.entity
{
	public class PlayerEntity : StatusEntity
	{
		public int level { get; set; }
		public int maxmp { get; set; }
		public List<SkillEntity> skills { get; set; }
	}
}
