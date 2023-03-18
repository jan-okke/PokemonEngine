using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Turtonator : Pokemon
	{
		public override string Name => "Turtonator";
		public override List<Ability> AvailableAbilities => new() {new Shellarmor() };
		public override Stats BaseStats => new Stats(60, 78, 135, 91, 85, 36);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Fire, PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Smog(), new Tackle() },
			[4] = new List<Move>() { new Ember() },
			[8] = new List<Move>() { new Protect() },
			[12] = new List<Move>() { new Endure() },
			[16] = new List<Move>() { new Flail() },
			[20] = new List<Move>() { new Incinerate() },
			[24] = new List<Move>() { new Irondefense() },
			[28] = new List<Move>() { new Dragonpulse() },
			[32] = new List<Move>() { new Bodyslam() },
			[36] = new List<Move>() { new Flamethrower() },
			[40] = new List<Move>() { new Shelltrap() },
			[44] = new List<Move>() { new Shellsmash() },
			[48] = new List<Move>() { new Overheat() },
			[52] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodypress(), new Bodyslam(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Burningjealousy(), new Dracometeor(), new Dragonclaw(), new Dragonpulse(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firespin(), new Flamethrower(), new Flashcannon(), new Fling(), new Focusblast(), new Gigaimpact(), new Heatcrash(), new Heatwave(), new Heavyslam(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Irondefense(), new Ironhead(), new Irontail(), new Lashout(), new Megakick(), new Megapunch(), new Outrage(), new Overheat(), new Payback(), new Protect(), new Rest(), new Revenge(), new Rocktomb(), new Round(), new Scaleshot(), new Scorchingsands(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Sunnyday(), new Taunt(), new Uproar(), new Venoshock(), new Willowisp(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Curse(), new Headsmash(), new Rapidspin(), new Wideguard() };
		public override int Weight => 2120;
		public override int ExpYield => 170;
		public override int CatchRate => 70;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}