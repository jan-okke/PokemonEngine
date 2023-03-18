using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ledian : Pokemon
	{
		public override string Name => "Ledian";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Earlybird() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Ironfist() };
		public override Stats BaseStats => new Stats(55, 35, 50, 85, 55, 110);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Supersonic(), new Swift() },
			[5] = new List<Move>() { new Supersonic() },
			[8] = new List<Move>() { new Swift() },
			[12] = new List<Move>() { new Lightscreen(), new Reflect(), new Safeguard() },
			[15] = new List<Move>() { new Machpunch() },
			[20] = new List<Move>() { new Roost() },
			[24] = new List<Move>() { new Strugglebug() },
			[29] = new List<Move>() { new Batonpass() },
			[33] = new List<Move>() { new Agility() },
			[38] = new List<Move>() { new Bugbuzz() },
			[42] = new List<Move>() { new Airslash() },
			[47] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Brickbreak(), new Bugbite(), new Bugbuzz(), new Confide(), new Dig(), new Doubleteam(), new Drainpunch(), new Endure(), new Facade(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Infestation(), new Knockoff(), new Lightscreen(), new Poweruppunch(), new Protect(), new Reflect(), new Rest(), new Return(), new Rocksmash(), new Roost(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Tailwind(), new Thief(), new Thunderpunch(), new Uproar(), new Uturn() };
		public override int Weight => 356;
		public override int ExpYield => 137;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}