using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dusclops : Pokemon
	{
		public override string Name => "Dusclops";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Frisk() };
		public override Stats BaseStats => new Stats(40, 70, 130, 60, 130, 25);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Shadowpunch() },
			[1] = new List<Move>() { new Moves.Shadowpunch(), new Moves.Firepunch(), new Moves.Icepunch(), new Moves.Thunderpunch(), new Moves.Gravity(), new Moves.Bind(), new Moves.Astonish(), new Moves.Leer(), new Moves.Disable(), new Moves.Shadowsneak() },
			[12] = new List<Move>() { new Moves.Confuseray() },
			[16] = new List<Move>() { new Moves.Nightshade() },
			[20] = new List<Move>() { new Moves.Payback() },
			[24] = new List<Move>() { new Moves.Willowisp() },
			[28] = new List<Move>() { new Moves.Meanlook() },
			[32] = new List<Move>() { new Moves.Hex() },
			[36] = new List<Move>() { new Moves.Curse() },
			[42] = new List<Move>() { new Moves.Shadowball() },
			[48] = new List<Move>() { new Moves.Futuresight() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Darkpulse(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focuspunch(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Helpinghand(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Payback(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Revenge(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp(), new Moves.Wonderroom() };
		public override int Weight => 306;
		public override int ExpYield => 159;
		public override int CatchRate => 90;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}