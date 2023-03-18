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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Unaware(), new Abilities.Klutz() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Simple() };
		public override Stats BaseStats => new Stats(67, 57, 55, 77, 55, 114);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Gust(), new Moves.Attract(), new Moves.Confusion(), new Moves.Endeavor() },
			[15] = new List<Move>() { new Moves.Aircutter() },
			[20] = new List<Move>() { new Moves.Imprison() },
			[25] = new List<Move>() { new Moves.Assurance() },
			[30] = new List<Move>() { new Moves.Amnesia() },
			[35] = new List<Move>() { new Moves.Airslash() },
			[40] = new List<Move>() { new Moves.Psychic() },
			[45] = new List<Move>() { new Moves.Calmmind() },
			[50] = new List<Move>() { new Moves.Futuresight() },
			[55] = new List<Move>() { new Moves.Simplebeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Airslash(), new Moves.Allyswitch(), new Moves.Amnesia(), new Moves.Assurance(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Calmmind(), new Moves.Charm(), new Moves.Dualwingbeat(), new Moves.Endure(), new Moves.Energyball(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fly(), new Moves.Futuresight(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Gyroball(), new Moves.Heatwave(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Nastyplot(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicfangs(), new Moves.Psychocut(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Speedswap(), new Moves.Steelwing(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swift(), new Moves.Taunt(), new Moves.Thief(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Uproar(), new Moves.Uturn(), new Moves.Venomdrench(), new Moves.Zenheadbutt() };
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