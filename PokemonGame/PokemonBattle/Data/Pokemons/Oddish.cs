using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Oddish : Pokemon
	{
		public override string Name => "Oddish";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Runaway() };
		public override Stats BaseStats => new Stats(45, 50, 55, 75, 65, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Growth() },
			[4] = new List<Move>() { new Acid() },
			[8] = new List<Move>() { new Sweetscent() },
			[12] = new List<Move>() { new Megadrain() },
			[14] = new List<Move>() { new Poisonpowder() },
			[16] = new List<Move>() { new Stunspore() },
			[18] = new List<Move>() { new Sleeppowder() },
			[20] = new List<Move>() { new Gigadrain() },
			[24] = new List<Move>() { new Toxic() },
			[28] = new List<Move>() { new Moonblast() },
			[32] = new List<Move>() { new Grassyterrain() },
			[36] = new List<Move>() { new Moonlight() },
			[40] = new List<Move>() { new Petaldance() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bulletseed(), new Charm(), new Cut(), new Dazzlinggleam(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Protect(), new Rest(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Toxic(), new Venoshock() };
		public override List<Move> EggMoves => new List<Move>() { new Afteryou(), new Charm(), new Flail(), new Ingrain(), new Leechseed(), new Naturepower(), new Razorleaf(), new Strengthsap(), new Synthesis(), new Teeterdance(), new Tickle() };
		public override int Weight => 54;
		public override int ExpYield => 64;
		public override int CatchRate => 255;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}