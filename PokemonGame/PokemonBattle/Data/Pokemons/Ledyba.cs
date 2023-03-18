using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ledyba : Pokemon
	{
		public override string Name => "Ledyba";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Rattled() };
		public override Stats BaseStats => new Stats(40, 20, 30, 55, 40, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle() },
			[5] = new List<Move>() { new Supersonic() },
			[8] = new List<Move>() { new Swift() },
			[12] = new List<Move>() { new Lightscreen(), new Reflect(), new Safeguard() },
			[15] = new List<Move>() { new Machpunch() },
			[19] = new List<Move>() { new Roost() },
			[22] = new List<Move>() { new Strugglebug() },
			[26] = new List<Move>() { new Batonpass() },
			[29] = new List<Move>() { new Agility() },
			[33] = new List<Move>() { new Bugbuzz() },
			[36] = new List<Move>() { new Airslash() },
			[40] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Brickbreak(), new Bugbite(), new Bugbuzz(), new Confide(), new Dig(), new Doubleteam(), new Drainpunch(), new Endure(), new Facade(), new Flash(), new Fling(), new Focuspunch(), new Frustration(), new Gigadrain(), new Hiddenpower(), new Icepunch(), new Infestation(), new Knockoff(), new Lightscreen(), new Poweruppunch(), new Protect(), new Reflect(), new Rest(), new Return(), new Roost(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Tailwind(), new Thief(), new Thunderpunch(), new Uproar(), new Uturn() };
		public override List<Move> EggMoves => new List<Move>() { new Bugbite(), new Counter(), new Encore(), new Knockoff(), new Psybeam(), new Screech(), new Tailwind() };
		public override int Weight => 108;
		public override int ExpYield => 53;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}