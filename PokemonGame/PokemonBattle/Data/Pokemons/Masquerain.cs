using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Masquerain : Pokemon
	{
		public override string Name => "Masquerain";
		public override List<Ability> AvailableAbilities => new() {new Intimidate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(70, 60, 62, 80, 100, 82);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Quiverdance(), new Whirlwind(), new Bugbuzz(), new Quickattack(), new Sweetscent() },
			[6] = new List<Move>() { new Quickattack() },
			[9] = new List<Move>() { new Sweetscent() },
			[14] = new List<Move>() { new Soak() },
			[17] = new List<Move>() { new Gust() },
			[22] = new List<Move>() { new Scaryface(), new Aircutter() },
			[26] = new List<Move>() { new Stunspore() },
			[32] = new List<Move>() { new Supersonic() },
			[38] = new List<Move>() { new Airslash() },
			[42] = new List<Move>() { new Bugbuzz() },
			[48] = new List<Move>() { new Whirlwind() },
			[52] = new List<Move>() { new Quiverdance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Blizzard(), new Bugbite(), new Bugbuzz(), new Confide(), new Defog(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Infestation(), new Liquidation(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Return(), new Roost(), new Round(), new Scald(), new Shadowball(), new Signalbeam(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Thief(), new Uturn(), new Waterpulse() };
		public override int Weight => 36;
		public override int ExpYield => 159;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}