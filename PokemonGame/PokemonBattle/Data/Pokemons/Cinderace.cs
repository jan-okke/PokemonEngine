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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Blaze() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Libero() };
		public override Stats BaseStats => new Stats(80, 116, 75, 65, 75, 119);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Pyroball() },
			[1] = new List<Move>() { new Moves.Pyroball(), new Moves.Feint(), new Moves.Tackle(), new Moves.Growl(), new Moves.Ember(), new Moves.Quickattack() },
			[12] = new List<Move>() { new Moves.Doublekick() },
			[19] = new List<Move>() { new Moves.Flamecharge() },
			[24] = new List<Move>() { new Moves.Agility() },
			[30] = new List<Move>() { new Moves.Headbutt() },
			[38] = new List<Move>() { new Moves.Counter() },
			[46] = new List<Move>() { new Moves.Bounce() },
			[54] = new List<Move>() { new Moves.Doubleedge() },
			[62] = new List<Move>() { new Moves.Courtchange() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Agility(), new Moves.Allyswitch(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Blastburn(), new Moves.Blazekick(), new Moves.Bounce(), new Moves.Bulkup(), new Moves.Coaching(), new Moves.Electroball(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firefang(), new Moves.Firepledge(), new Moves.Firepunch(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Flareblitz(), new Moves.Focusblast(), new Moves.Focusenergy(), new Moves.Gigaimpact(), new Moves.Gunkshot(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Mudshot(), new Moves.Overheat(), new Moves.Protect(), new Moves.Rest(), new Moves.Revenge(), new Moves.Reversal(), new Moves.Round(), new Moves.Scorchingsands(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snarl(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swift(), new Moves.Taunt(), new Moves.Uturn(), new Moves.Workup(), new Moves.Zenheadbutt() };
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