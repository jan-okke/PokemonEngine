using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Jangmoo : Pokemon
	{
		public override string Name => "Jangmo-o";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Bulletproof(), new Abilities.Soundproof() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Overcoat() };
		public override Stats BaseStats => new Stats(45, 55, 65, 45, 45, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Tackle(), new Moves.Leer() },
			[4] = new List<Move>() { new Moves.Protect() },
			[8] = new List<Move>() { new Moves.Dragontail() },
			[12] = new List<Move>() { new Moves.Scaryface() },
			[16] = new List<Move>() { new Moves.Headbutt() },
			[20] = new List<Move>() { new Moves.Workup() },
			[24] = new List<Move>() { new Moves.Screech() },
			[28] = new List<Move>() { new Moves.Irondefense() },
			[32] = new List<Move>() { new Moves.Dragonclaw() },
			[36] = new List<Move>() { new Moves.Nobleroar() },
			[40] = new List<Move>() { new Moves.Dragondance() },
			[44] = new List<Move>() { new Moves.Outrage() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Brickbreak(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Hiddenpower(), new Moves.Irondefense(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Lowkick(), new Moves.Outrage(), new Moves.Payback(), new Moves.Protect(), new Moves.Rest(), new Moves.Reversal(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scaleshot(), new Moves.Scaryface(), new Moves.Screech(), new Moves.Shadowclaw(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Substitute(), new Moves.Swordsdance(), new Moves.Taunt(), new Moves.Uproar(), new Moves.Workup(), new Moves.Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Counter(), new Moves.Dragonbreath(), new Moves.Focuspunch() };
		public override int Weight => 297;
		public override int ExpYield => 60;
		public override int CatchRate => 45;
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