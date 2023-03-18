using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Metang : Pokemon
	{
		public override string Name => "Metang";
		public override List<Ability> AvailableAbilities => new() {new Clearbody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Lightmetal() };
		public override Stats BaseStats => new Stats(60, 75, 100, 55, 80, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Steel, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Confusion(), new Metalclaw() },
			[1] = new List<Move>() { new Confusion(), new Metalclaw(), new Bulletpunch(), new Tackle() },
			[6] = new List<Move>() { new Zenheadbutt() },
			[12] = new List<Move>() { new Magnetrise() },
			[18] = new List<Move>() { new Flashcannon() },
			[26] = new List<Move>() { new Takedown() },
			[34] = new List<Move>() { new Psychic() },
			[42] = new List<Move>() { new Scaryface() },
			[50] = new List<Move>() { new Meteormash() },
			[58] = new List<Move>() { new Irondefense() },
			[66] = new List<Move>() { new Agility() },
			[74] = new List<Move>() { new Hyperbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Allyswitch(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Cosmicpower(), new Cut(), new Doubleteam(), new Earthquake(), new Endure(), new Expandingforce(), new Explosion(), new Facade(), new Flash(), new Flashcannon(), new Grassknot(), new Gyroball(), new Hiddenpower(), new Hyperbeam(), new Icepunch(), new Icywind(), new Irondefense(), new Ironhead(), new Lightscreen(), new Meteorbeam(), new Protect(), new Psychic(), new Psychocut(), new Psychup(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Scaryface(), new Selfdestruct(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Stealthrock(), new Steelbeam(), new Steelroller(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunderpunch(), new Trick(), new Zenheadbutt() };
		public override int Weight => 2025;
		public override int ExpYield => 147;
		public override int CatchRate => 3;
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