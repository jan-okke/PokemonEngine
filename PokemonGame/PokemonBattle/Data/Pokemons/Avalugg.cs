using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Avalugg : Pokemon
	{
		public override string Name => "Avalugg";
		public override List<Ability> AvailableAbilities => new() {new Owntempo(), new Icebody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sturdy() };
		public override Stats BaseStats => new Stats(95, 117, 184, 44, 46, 28);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Bodyslam() },
			[1] = new List<Move>() { new Bodyslam(), new Wideguard(), new Rapidspin(), new Harden(), new Tackle(), new Powdersnow() },
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
			[41] = new List<Move>() { new Blizzard() },
			[46] = new List<Move>() { new Doubleedge() },
			[51] = new List<Move>() { new Skullbash() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Avalanche(), new Blizzard(), new Bodypress(), new Bodyslam(), new Bulldoze(), new Crunch(), new Earthquake(), new Endure(), new Facade(), new Flashcannon(), new Gigaimpact(), new Gyroball(), new Hail(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hydropump(), new Hyperbeam(), new Icebeam(), new Icefang(), new Iciclespear(), new Icywind(), new Irondefense(), new Ironhead(), new Protect(), new Raindance(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Stompingtantrum(), new Stoneedge(), new Substitute(), new Superpower(), new Surf() };
		public override int Weight => 5050;
		public override int ExpYield => 180;
		public override int CatchRate => 55;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}