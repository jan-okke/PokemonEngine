using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nidoran♂ : Pokemon
	{
		public override string Name => "Nidoran♂";
		public override List<Ability> AvailableAbilities => new() {new Poisonpoint(), new Rivalry() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(46, 57, 40, 40, 40, 50);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leer(), new Poisonsting() },
			[5] = new List<Move>() { new Peck() },
			[10] = new List<Move>() { new Focusenergy() },
			[15] = new List<Move>() { new Furyattack() },
			[20] = new List<Move>() { new Toxicspikes() },
			[25] = new List<Move>() { new Doublekick() },
			[30] = new List<Move>() { new Hornattack() },
			[35] = new List<Move>() { new Helpinghand() },
			[40] = new List<Move>() { new Toxic() },
			[45] = new List<Move>() { new Flatter() },
			[50] = new List<Move>() { new Poisonjab() },
			[55] = new List<Move>() { new Earthpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Beatup(), new Blizzard(), new Bodyslam(), new Cut(), new Dig(), new Doubleteam(), new Drillrun(), new Earthpower(), new Endure(), new Facade(), new Focusenergy(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Irontail(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Rocksmash(), new Round(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Smartstrike(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Thunder(), new Thunderbolt(), new Toxic(), new Toxicspikes(), new Venomdrench(), new Venoshock(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Beatup(), new Confusion(), new Counter(), new Disable(), new Headsmash(), new Horndrill(), new Poisontail(), new Suckerpunch(), new Supersonic(), new Takedown(), new Thrash(), new Venomdrench() };
		public override int Weight => 90;
		public override int ExpYield => 55;
		public override int CatchRate => 235;
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