using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Swoobat : Pokemon
	{
		public override string Name => "Swoobat";
		public override List<Ability> AvailableAbilities => new() {new Unaware(), new Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Simple() };
		public override Stats BaseStats => new Stats(67, 57, 55, 77, 55, 114);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Gust(), new Attract(), new Confusion(), new Endeavor() },
			[15] = new List<Move>() { new Aircutter() },
			[20] = new List<Move>() { new Imprison() },
			[25] = new List<Move>() { new Assurance() },
			[30] = new List<Move>() { new Amnesia() },
			[35] = new List<Move>() { new Airslash() },
			[40] = new List<Move>() { new Psychic() },
			[45] = new List<Move>() { new Calmmind() },
			[50] = new List<Move>() { new Futuresight() },
			[55] = new List<Move>() { new Simplebeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Airslash(), new Allyswitch(), new Amnesia(), new Assurance(), new Attract(), new Batonpass(), new Calmmind(), new Charm(), new Dualwingbeat(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Faketears(), new Fly(), new Futuresight(), new Gigadrain(), new Gigaimpact(), new Gyroball(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Lightscreen(), new Nastyplot(), new Protect(), new Psychic(), new Psychicfangs(), new Psychocut(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Speedswap(), new Steelwing(), new Storedpower(), new Substitute(), new Swift(), new Taunt(), new Thief(), new Thunderwave(), new Trick(), new Trickroom(), new Uproar(), new Uturn(), new Venomdrench(), new Zenheadbutt() };
		public override int Weight => 105;
		public override int ExpYield => 149;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}