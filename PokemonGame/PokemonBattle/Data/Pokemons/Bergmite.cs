using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Bergmite : Pokemon
	{
		public override string Name => "Bergmite";
		public override List<Ability> AvailableAbilities => new() {new Owntempo(), new Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sturdy() };
		public override Stats BaseStats => new Stats(55, 69, 85, 28, 32, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Rapidspin(), new Harden() },
			[3] = new List<Move>() { new Tackle() },
			[6] = new List<Move>() { new Powdersnow() },
			[9] = new List<Move>() { new Curse() },
			[12] = new List<Move>() { new Icywind() },
			[15] = new List<Move>() { new Protect() },
			[18] = new List<Move>() { new Avalanche() },
			[21] = new List<Move>() { new Bite() },
			[24] = new List<Move>() { new Icefang() },
			[27] = new List<Move>() { new Irondefense() },
			[30] = new List<Move>() { new Recover() },
			[33] = new List<Move>() { new Crunch() },
			[36] = new List<Move>() { new Takedown() },
			[39] = new List<Move>() { new Blizzard() },
			[42] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Crunch(), new Endure(), new Facade(), new Flashcannon(), new Gyroball(), new Hail(), new Hiddenpower(), new Icebeam(), new Icefang(), new Iciclespear(), new Icywind(), new Irondefense(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Stoneedge(), new Substitute(), new Surf() };
		public override List<Move> EggMoves => new List<Move>() { new Auroraveil(), new Mirrorcoat(), new Mist() };
		public override int Weight => 995;
		public override int ExpYield => 61;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}