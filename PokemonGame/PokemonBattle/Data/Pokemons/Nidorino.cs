using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nidorino : Pokemon
	{
		public override string Name => "Nidorino";
		public override List<Ability> AvailableAbilities => new() {new Poisonpoint(), new Rivalry() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(61, 72, 57, 65, 55, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leer(), new Poisonsting(), new Peck(), new Focusenergy() },
			[15] = new List<Move>() { new Furyattack() },
			[22] = new List<Move>() { new Toxicspikes() },
			[29] = new List<Move>() { new Doublekick() },
			[36] = new List<Move>() { new Hornattack() },
			[43] = new List<Move>() { new Helpinghand() },
			[50] = new List<Move>() { new Toxic() },
			[57] = new List<Move>() { new Flatter() },
			[64] = new List<Move>() { new Poisonjab() },
			[71] = new List<Move>() { new Earthpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Beatup(), new Blizzard(), new Bodyslam(), new Cut(), new Dig(), new Doubleteam(), new Drillrun(), new Earthpower(), new Endure(), new Facade(), new Focusenergy(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Irontail(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Rocksmash(), new Round(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Smartstrike(), new Snore(), new Stompingtantrum(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Thunder(), new Thunderbolt(), new Toxic(), new Toxicspikes(), new Venomdrench(), new Venoshock(), new Waterpulse() };
		public override int Weight => 195;
		public override int ExpYield => 128;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}