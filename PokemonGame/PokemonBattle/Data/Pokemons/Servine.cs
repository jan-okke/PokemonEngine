using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Servine : Pokemon
	{
		public override string Name => "Servine";
		public override List<Ability> AvailableAbilities => new() {new Overgrow() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Contrary() };
		public override Stats BaseStats => new Stats(60, 60, 75, 83, 60, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Leer(), new Vinewhip(), new Wrap() },
			[4] = new List<Move>() { new Leer() },
			[7] = new List<Move>() { new Vinewhip() },
			[10] = new List<Move>() { new Wrap() },
			[13] = new List<Move>() { new Growth() },
			[16] = new List<Move>() { new Leaftornado() },
			[20] = new List<Move>() { new Leechseed() },
			[24] = new List<Move>() { new Megadrain() },
			[28] = new List<Move>() { new Slam() },
			[32] = new List<Move>() { new Leafblade() },
			[36] = new List<Move>() { new Coil() },
			[40] = new List<Move>() { new Gigadrain() },
			[44] = new List<Move>() { new Wringout() },
			[48] = new List<Move>() { new Gastroacid() },
			[52] = new List<Move>() { new Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Aquatail(), new Attract(), new Bind(), new Calmmind(), new Confide(), new Cut(), new Defog(), new Doubleteam(), new Energyball(), new Facade(), new Frustration(), new Gastroacid(), new Gigadrain(), new Grassknot(), new Grasspledge(), new Hiddenpower(), new Irontail(), new Knockoff(), new Lightscreen(), new Naturepower(), new Protect(), new Reflect(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snatch(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Taunt(), new Torment(), new Toxic(), new Workup(), new Worryseed() };
		public override int Weight => 160;
		public override int ExpYield => 145;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}