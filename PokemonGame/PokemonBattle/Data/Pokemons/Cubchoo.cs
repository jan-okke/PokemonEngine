using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cubchoo : Pokemon
	{
		public override string Name => "Cubchoo";
		public override List<Ability> AvailableAbilities => new() {new Snowcloak(), new Slushrush() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rattled() };
		public override Stats BaseStats => new Stats(55, 70, 40, 60, 40, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Powdersnow(), new Growl() },
			[3] = new List<Move>() { new Endure() },
			[6] = new List<Move>() { new Furyswipes() },
			[9] = new List<Move>() { new Icywind() },
			[12] = new List<Move>() { new Playnice() },
			[15] = new List<Move>() { new Brine() },
			[18] = new List<Move>() { new Frostbreath() },
			[21] = new List<Move>() { new Slash() },
			[24] = new List<Move>() { new Flail() },
			[27] = new List<Move>() { new Charm() },
			[30] = new List<Move>() { new Hail() },
			[33] = new List<Move>() { new Thrash() },
			[36] = new List<Move>() { new Rest() },
			[39] = new List<Move>() { new Blizzard() },
			[42] = new List<Move>() { new Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Assurance(), new Attract(), new Avalanche(), new Blizzard(), new Brine(), new Charm(), new Dig(), new Encore(), new Endure(), new Facade(), new Fling(), new Grassknot(), new Hail(), new Hiddenpower(), new Icebeam(), new Icefang(), new Icepunch(), new Icywind(), new Lowkick(), new Megakick(), new Megapunch(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Rocktomb(), new Round(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Substitute(), new Superpower(), new Surf() };
		public override List<Move> EggMoves => new List<Move>() { new Focuspunch(), new Nightslash(), new Yawn() };
		public override int Weight => 85;
		public override int ExpYield => 61;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}