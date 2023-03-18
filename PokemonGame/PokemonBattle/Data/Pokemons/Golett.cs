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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Ironfist(), new Abilities.Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Noguard() };
		public override Stats BaseStats => new Stats(59, 74, 50, 35, 50, 35);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Mudslap(), new Moves.Astonish() },
			[4] = new List<Move>() { new Moves.Defensecurl() },
			[8] = new List<Move>() { new Moves.Pound() },
			[12] = new List<Move>() { new Moves.Shadowpunch() },
			[16] = new List<Move>() { new Moves.Curse() },
			[20] = new List<Move>() { new Moves.Nightshade() },
			[24] = new List<Move>() { new Moves.Stompingtantrum() },
			[28] = new List<Move>() { new Moves.Irondefense() },
			[32] = new List<Move>() { new Moves.Megapunch() },
			[36] = new List<Move>() { new Moves.Shadowball() },
			[40] = new List<Move>() { new Moves.Heavyslam() },
			[44] = new List<Move>() { new Moves.Phantomforce() },
			[48] = new List<Move>() { new Moves.Hammerarm() },
			[52] = new List<Move>() { new Moves.Earthquake() },
			[56] = new List<Move>() { new Moves.Dynamicpunch() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Dig(), new Moves.Drainpunch(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Heavyslam(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Irondefense(), new Moves.Lowkick(), new Moves.Lowsweep(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Phantomforce(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scorchingsands(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Substitute(), new Moves.Superpower(), new Moves.Thief(), new Moves.Thunderpunch() };
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