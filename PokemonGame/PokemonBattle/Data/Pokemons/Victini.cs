using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Victini : Pokemon
	{
		public override string Name => "Victini";
		public override List<Ability> AvailableAbilities => new() {new Victorystar() };
		public override Stats BaseStats => new Stats(100, 100, 100, 100, 100, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Psychic, PokemonType.Fire };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Vcreate(), new Quickattack(), new Flamecharge(), new Confusion(), new Focusenergy() },
			[7] = new List<Move>() { new Workup() },
			[14] = new List<Move>() { new Incinerate() },
			[21] = new List<Move>() { new Storedpower() },
			[28] = new List<Move>() { new Headbutt() },
			[35] = new List<Move>() { new Endure() },
			[42] = new List<Move>() { new Zenheadbutt() },
			[49] = new List<Move>() { new Inferno() },
			[56] = new List<Move>() { new Reversal() },
			[63] = new List<Move>() { new Searingshot() },
			[70] = new List<Move>() { new Doubleedge() },
			[77] = new List<Move>() { new Flareblitz() },
			[84] = new List<Move>() { new Overheat() },
			[91] = new List<Move>() { new Finalgambit() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Batonpass(), new Blazekick(), new Bounce(), new Brickbreak(), new Dazzlinggleam(), new Encore(), new Endure(), new Energyball(), new Expandingforce(), new Facade(), new Fireblast(), new Firepunch(), new Firespin(), new Flamethrower(), new Flareblitz(), new Fling(), new Focusblast(), new Focusenergy(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Guardswap(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Lightscreen(), new Megakick(), new Megapunch(), new Mysticalfire(), new Overheat(), new Powerswap(), new Protect(), new Psychic(), new Psyshock(), new Rest(), new Reversal(), new Round(), new Safeguard(), new Scorchingsands(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Solarbeam(), new Speedswap(), new Storedpower(), new Substitute(), new Sunnyday(), new Swift(), new Taunt(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Trick(), new Trickroom(), new Uproar(), new Uturn(), new Wildcharge(), new Willowisp(), new Workup(), new Zenheadbutt() };
		public override int Weight => 40;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 3,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}