using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Nidoranfe : Pokemon
	{
		public override string Name => "Nidoran♀";
		public override List<Ability> AvailableAbilities => new() {new Poisonpoint(), new Rivalry() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Hustle() };
		public override Stats BaseStats => new Stats(55, 47, 52, 40, 40, 41);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Growl(), new Poisonsting() },
			[5] = new List<Move>() { new Scratch() },
			[10] = new List<Move>() { new Tailwhip() },
			[15] = new List<Move>() { new Furyswipes() },
			[20] = new List<Move>() { new Toxicspikes() },
			[25] = new List<Move>() { new Doublekick() },
			[30] = new List<Move>() { new Bite() },
			[35] = new List<Move>() { new Helpinghand() },
			[40] = new List<Move>() { new Toxic() },
			[45] = new List<Move>() { new Flatter() },
			[50] = new List<Move>() { new Crunch() },
			[55] = new List<Move>() { new Earthpower() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Beatup(), new Blizzard(), new Bodyslam(), new Charm(), new Crunch(), new Cut(), new Dig(), new Doubleteam(), new Earthpower(), new Endure(), new Facade(), new Focusenergy(), new Helpinghand(), new Hiddenpower(), new Icebeam(), new Irontail(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Rocksmash(), new Round(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thief(), new Thunder(), new Thunderbolt(), new Toxic(), new Toxicspikes(), new Venomdrench(), new Venoshock(), new Waterpulse() };
		public override List<Move> EggMoves => new List<Move>() { new Beatup(), new Charm(), new Counter(), new Disable(), new Focusenergy(), new Poisonfang(), new Poisontail(), new Skullbash(), new Supersonic(), new Takedown(), new Venomdrench() };
		public override int Weight => 70;
		public override int ExpYield => 55;
		public override int CatchRate => 235;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 1,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}