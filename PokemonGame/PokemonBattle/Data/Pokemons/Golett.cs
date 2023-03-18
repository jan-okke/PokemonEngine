using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Golett : Pokemon
	{
		public override string Name => "Golett";
		public override List<Ability> AvailableAbilities => new() {new Ironfist(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Noguard() };
		public override Stats BaseStats => new Stats(59, 74, 50, 35, 35, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudslap(), new Astonish() },
			[4] = new List<Move>() { new Defensecurl() },
			[8] = new List<Move>() { new Pound() },
			[12] = new List<Move>() { new Shadowpunch() },
			[16] = new List<Move>() { new Curse() },
			[20] = new List<Move>() { new Nightshade() },
			[24] = new List<Move>() { new Stompingtantrum() },
			[28] = new List<Move>() { new Irondefense() },
			[32] = new List<Move>() { new Megapunch() },
			[36] = new List<Move>() { new Shadowball() },
			[40] = new List<Move>() { new Heavyslam() },
			[44] = new List<Move>() { new Phantomforce() },
			[48] = new List<Move>() { new Hammerarm() },
			[52] = new List<Move>() { new Earthquake() },
			[56] = new List<Move>() { new Dynamicpunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Brickbreak(), new Bulldoze(), new Dig(), new Drainpunch(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Grassknot(), new Gyroball(), new Heavyslam(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Icepunch(), new Icywind(), new Imprison(), new Irondefense(), new Lowkick(), new Lowsweep(), new Megakick(), new Megapunch(), new Phantomforce(), new Poltergeist(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Scorchingsands(), new Selfdestruct(), new Shadowball(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Substitute(), new Superpower(), new Thief(), new Thunderpunch() };
		public override int Weight => 920;
		public override int ExpYield => 61;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}