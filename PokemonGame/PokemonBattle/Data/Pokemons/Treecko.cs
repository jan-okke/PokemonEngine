using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Treecko : Pokemon
	{
		public override string Name => "Treecko";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unburden() };
		public override Stats BaseStats => new Stats(40, 45, 35, 65, 55, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Pound(), new Leer() },
			[3] = new List<Move>() { new Leafage() },
			[6] = new List<Move>() { new Quickattack() },
			[9] = new List<Move>() { new Megadrain() },
			[12] = new List<Move>() { new Detect() },
			[15] = new List<Move>() { new Quickguard() },
			[18] = new List<Move>() { new Assurance() },
			[21] = new List<Move>() { new Gigadrain() },
			[24] = new List<Move>() { new Slam() },
			[27] = new List<Move>() { new Doubleteam() },
			[30] = new List<Move>() { new Energyball() },
			[33] = new List<Move>() { new Screech() },
			[36] = new List<Move>() { new Endeavor() },
			[39] = new List<Move>() { new Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Agility(), new Assurance(), new Attract(), new Bodyslam(), new Brickbreak(), new Bulletseed(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Drainpunch(), new Endure(), new Energyball(), new Facade(), new Flash(), new Fling(), new Focuspunch(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Irontail(), new Leafstorm(), new Lowkick(), new Magicalleaf(), new Megakick(), new Megapunch(), new Protect(), new Rest(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Screech(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Thunderpunch(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Absorb(), new Crunch(), new Crushclaw(), new Doublekick(), new Dragonbreath(), new Endeavor(), new Grassyterrain(), new Leafstorm(), new Leechseed(), new Magicalleaf(), new Nightslash(), new Slash(), new Synthesis(), new Worryseed() };
		public override int Weight => 50;
		public override int ExpYield => 62;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}