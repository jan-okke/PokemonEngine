using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sirfetchd : Pokemon
	{
		public override string Name => "Sirfetch'd";
		public override List<Ability> AvailableAbilities => new() {new Steadfast() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Scrappy() };
		public override Stats BaseStats => new Stats(62, 135, 95, 68, 82, 65);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fighting };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Irondefense() },
			[1] = new List<Move>() { new Irondefense(), new Firstimpression(), new Peck(), new Sandattack(), new Leer(), new Furycutter() },
			[15] = new List<Move>() { new Rocksmash() },
			[20] = new List<Move>() { new Brutalswing() },
			[25] = new List<Move>() { new Detect() },
			[30] = new List<Move>() { new Knockoff() },
			[35] = new List<Move>() { new Defog() },
			[40] = new List<Move>() { new Brickbreak() },
			[45] = new List<Move>() { new Swordsdance() },
			[50] = new List<Move>() { new Slam() },
			[55] = new List<Move>() { new Leafblade() },
			[60] = new List<Move>() { new Finalgambit() },
			[65] = new List<Move>() { new Bravebird() },
			[70] = new List<Move>() { new Meteorassault() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Bodyslam(), new Bravebird(), new Brickbreak(), new Brutalswing(), new Closecombat(), new Coaching(), new Dualwingbeat(), new Endure(), new Facade(), new Focusenergy(), new Grassyglide(), new Helpinghand(), new Hiddenpower(), new Irondefense(), new Leafblade(), new Poisonjab(), new Protect(), new Rest(), new Retaliate(), new Revenge(), new Round(), new Sleeptalk(), new Snore(), new Solarblade(), new Steelwing(), new Substitute(), new Sunnyday(), new Superpower(), new Swordsdance(), new Throatchop(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Counter(), new Covet(), new Curse(), new Doubleedge(), new Feint(), new Flail(), new Nightslash(), new Quickattack(), new Quickguard(), new Simplebeam(), new Skyattack() };
		public override int Weight => 1170;
		public override int ExpYield => 177;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}