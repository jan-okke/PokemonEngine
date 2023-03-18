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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Unburden() };
		public override Stats BaseStats => new Stats(40, 45, 35, 65, 55, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Pound(), new Moves.Leer() },
			[3] = new List<Move>() { new Moves.Leafage() },
			[6] = new List<Move>() { new Moves.Quickattack() },
			[9] = new List<Move>() { new Moves.Megadrain() },
			[12] = new List<Move>() { new Moves.Detect() },
			[15] = new List<Move>() { new Moves.Quickguard() },
			[18] = new List<Move>() { new Moves.Assurance() },
			[21] = new List<Move>() { new Moves.Gigadrain() },
			[24] = new List<Move>() { new Moves.Slam() },
			[27] = new List<Move>() { new Moves.Doubleteam() },
			[30] = new List<Move>() { new Moves.Energyball() },
			[33] = new List<Move>() { new Moves.Screech() },
			[36] = new List<Move>() { new Moves.Endeavor() },
			[39] = new List<Move>() { new Moves.Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Aerialace(), new Moves.Agility(), new Moves.Assurance(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulletseed(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grasspledge(), new Moves.Grassyglide(), new Moves.Grassyterrain(), new Moves.Hiddenpower(), new Moves.Irontail(), new Moves.Leafstorm(), new Moves.Lowkick(), new Moves.Magicalleaf(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Protect(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Swordsdance(), new Moves.Thunderpunch(), new Moves.Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Absorb(), new Moves.Crunch(), new Moves.Crushclaw(), new Moves.Doublekick(), new Moves.Dragonbreath(), new Moves.Endeavor(), new Moves.Grassyterrain(), new Moves.Leafstorm(), new Moves.Leechseed(), new Moves.Magicalleaf(), new Moves.Nightslash(), new Moves.Slash(), new Moves.Synthesis(), new Moves.Worryseed() };
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