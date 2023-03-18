using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Hoppip : Pokemon
	{
		public override string Name => "Hoppip";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Leafguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Infiltrator() };
		public override Stats BaseStats => new Stats(35, 35, 40, 35, 55, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Splash(), new Absorb() },
			[4] = new List<Move>() { new Synthesis() },
			[6] = new List<Move>() { new Tailwhip() },
			[8] = new List<Move>() { new Tackle() },
			[10] = new List<Move>() { new Fairywind() },
			[12] = new List<Move>() { new Poisonpowder() },
			[14] = new List<Move>() { new Stunspore() },
			[16] = new List<Move>() { new Sleeppowder() },
			[19] = new List<Move>() { new Bulletseed() },
			[22] = new List<Move>() { new Leechseed() },
			[25] = new List<Move>() { new Megadrain() },
			[28] = new List<Move>() { new Acrobatics() },
			[31] = new List<Move>() { new Ragepowder() },
			[34] = new List<Move>() { new Cottonspore() },
			[37] = new List<Move>() { new Uturn() },
			[40] = new List<Move>() { new Worryseed() },
			[43] = new List<Move>() { new Gigadrain() },
			[46] = new List<Move>() { new Bounce() },
			[49] = new List<Move>() { new Memento() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Attract(), new Bounce(), new Bulletseed(), new Confide(), new Dazzlinggleam(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Frustration(), new Gigadrain(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Infestation(), new Protect(), new Psychup(), new Reflect(), new Rest(), new Return(), new Round(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Uturn(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Aromatherapy(), new Confusion(), new Cottonguard(), new Doubleedge(), new Encore(), new Grassyterrain(), new Helpinghand(), new Seedbomb(), new Strengthsap(), new Worryseed() };
		public override int Weight => 5;
		public override int ExpYield => 50;
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