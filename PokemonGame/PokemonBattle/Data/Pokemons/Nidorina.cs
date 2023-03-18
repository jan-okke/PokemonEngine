using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nidorina : Pokemon
	{
		public override string Name => "Nidorina";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Poisonpoint(), new Abilities.Rivalry() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Hustle() };
		public override Stats BaseStats => new Stats(70, 62, 67, 55, 55, 56);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Growl(), new Moves.Poisonsting(), new Moves.Scratch(), new Moves.Tailwhip() },
			[15] = new List<Move>() { new Moves.Furyswipes() },
			[22] = new List<Move>() { new Moves.Toxicspikes() },
			[29] = new List<Move>() { new Moves.Doublekick() },
			[36] = new List<Move>() { new Moves.Bite() },
			[43] = new List<Move>() { new Moves.Helpinghand() },
			[50] = new List<Move>() { new Moves.Toxic() },
			[57] = new List<Move>() { new Moves.Flatter() },
			[64] = new List<Move>() { new Moves.Crunch() },
			[71] = new List<Move>() { new Moves.Earthpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Attract(), new Moves.Beatup(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Charm(), new Moves.Crunch(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Earthpower(), new Moves.Endure(), new Moves.Facade(), new Moves.Focusenergy(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Icebeam(), new Moves.Irontail(), new Moves.Poisonjab(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Stompingtantrum(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thief(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Toxic(), new Moves.Toxicspikes(), new Moves.Venomdrench(), new Moves.Venoshock(), new Moves.Waterpulse() };
		public override int Weight => 200;
		public override int ExpYield => 128;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}