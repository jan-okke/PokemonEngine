using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cinderace : Pokemon
	{
		public override string Name => "Cinderace";
		public override List<Ability> AvailableAbilities => new() {new Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Libero() };
		public override Stats BaseStats => new Stats(80, 116, 75, 65, 75, 119);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Pyroball() },
			[1] = new List<Move>() { new Pyroball(), new Feint(), new Tackle(), new Growl(), new Ember(), new Quickattack() },
			[12] = new List<Move>() { new Doublekick() },
			[19] = new List<Move>() { new Flamecharge() },
			[24] = new List<Move>() { new Agility() },
			[30] = new List<Move>() { new Headbutt() },
			[38] = new List<Move>() { new Counter() },
			[46] = new List<Move>() { new Bounce() },
			[54] = new List<Move>() { new Doubleedge() },
			[62] = new List<Move>() { new Courtchange() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Agility(), new Allyswitch(), new Assurance(), new Attract(), new Batonpass(), new Blastburn(), new Blazekick(), new Bounce(), new Bulkup(), new Coaching(), new Electroball(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Firepledge(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Focusblast(), new Focusenergy(), new Gigaimpact(), new Gunkshot(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Ironhead(), new Lowkick(), new Lowsweep(), new Megakick(), new Mudshot(), new Overheat(), new Protect(), new Rest(), new Revenge(), new Reversal(), new Round(), new Scorchingsands(), new Shadowball(), new Sleeptalk(), new Snarl(), new Snore(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Uturn(), new Workup(), new Zenheadbutt() };
		public override int Weight => 330;
		public override int ExpYield => 265;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 3
		};
	}
}