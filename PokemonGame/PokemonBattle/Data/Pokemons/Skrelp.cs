using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Skrelp : Pokemon
	{
		public override string Name => "Skrelp";
		public override List<Ability> AvailableAbilities => new() {new Poisonpoint(), new Poisontouch() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Adaptability() };
		public override Stats BaseStats => new Stats(50, 60, 60, 60, 60, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Poison, PokemonType.Water };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Smokescreen() },
			[5] = new List<Move>() { new Acid() },
			[10] = new List<Move>() { new Watergun() },
			[15] = new List<Move>() { new Tailwhip() },
			[20] = new List<Move>() { new Doubleteam() },
			[25] = new List<Move>() { new Poisontail() },
			[30] = new List<Move>() { new Waterpulse() },
			[35] = new List<Move>() { new Toxic() },
			[40] = new List<Move>() { new Dragonpulse() },
			[45] = new List<Move>() { new Aquatail() },
			[50] = new List<Move>() { new Sludgebomb() },
			[55] = new List<Move>() { new Hydropump() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Dive(), new Dragonpulse(), new Endure(), new Facade(), new Flipturn(), new Gunkshot(), new Hail(), new Hiddenpower(), new Hydropump(), new Icywind(), new Irontail(), new Outrage(), new Playrough(), new Protect(), new Raindance(), new Rest(), new Round(), new Scald(), new Scaleshot(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Surf(), new Thunderbolt(), new Toxicspikes(), new Venomdrench(), new Venoshock(), new Waterfall() };
		public override List<Move> EggMoves => new List<Move>() { new Acidarmor(), new Dragontail(), new Haze(), new Twister() };
		public override int Weight => 73;
		public override int ExpYield => 64;
		public override int CatchRate => 225;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}