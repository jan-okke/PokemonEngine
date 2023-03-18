using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Dusknoir : Pokemon
	{
		public override string Name => "Dusknoir";
		public override List<Ability> AvailableAbilities => new() {new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Frisk() };
		public override Stats BaseStats => new Stats(45, 100, 135, 65, 135, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Shadowpunch(), new Firepunch(), new Icepunch(), new Thunderpunch(), new Gravity(), new Bind(), new Astonish(), new Leer(), new Disable(), new Shadowsneak() },
			[12] = new List<Move>() { new Confuseray() },
			[16] = new List<Move>() { new Nightshade() },
			[20] = new List<Move>() { new Payback() },
			[24] = new List<Move>() { new Willowisp() },
			[28] = new List<Move>() { new Meanlook() },
			[32] = new List<Move>() { new Hex() },
			[36] = new List<Move>() { new Curse() },
			[42] = new List<Move>() { new Shadowball() },
			[48] = new List<Move>() { new Futuresight() },
			[54] = new List<Move>() { new Destinybond() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Darkestlariat(), new Darkpulse(), new Doubleteam(), new Dreameater(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Futuresight(), new Gigaimpact(), new Helpinghand(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icepunch(), new Icywind(), new Imprison(), new Megakick(), new Megapunch(), new Metronome(), new Payback(), new Poltergeist(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Rest(), new Revenge(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Shadowball(), new Skillswap(), new Skittersmack(), new Sleeptalk(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Taunt(), new Thief(), new Thunderpunch(), new Torment(), new Trick(), new Trickroom(), new Willowisp(), new Wonderroom() };
		public override int Weight => 1066;
		public override int ExpYield => 263;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}