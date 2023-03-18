using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Groudon : Pokemon
	{
		public override string Name => "Groudon";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Drought() };
		public override Stats BaseStats => new Stats(100, 150, 140, 100, 90, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Mudshot(), new Moves.Ancientpower(), new Moves.Lavaplume(), new Moves.Scaryface() },
			[9] = new List<Move>() { new Moves.Earthpower() },
			[18] = new List<Move>() { new Moves.Bulkup() },
			[27] = new List<Move>() { new Moves.Earthquake() },
			[36] = new List<Move>() { new Moves.Hammerarm() },
			[45] = new List<Move>() { new Moves.Fissure() },
			[54] = new List<Move>() { new Moves.Rest() },
			[63] = new List<Move>() { new Moves.Precipiceblades() },
			[72] = new List<Move>() { new Moves.Fireblast() },
			[81] = new List<Move>() { new Moves.Solarbeam() },
			[90] = new List<Move>() { new Moves.Eruption() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Brutalswing(), new Moves.Bulkup(), new Moves.Bulldoze(), new Moves.Cut(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Dragonclaw(), new Moves.Dragonpulse(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Gigaimpact(), new Moves.Heatcrash(), new Moves.Heavyslam(), new Moves.Hiddenpower(), new Moves.Highhorsepower(), new Moves.Hyperbeam(), new Moves.Ironhead(), new Moves.Irontail(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mudshot(), new Moves.Overheat(), new Moves.Protect(), new Moves.Psychup(), new Moves.Rest(), new Moves.Roar(), new Moves.Rockclimb(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocksmash(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Scaryface(), new Moves.Scorchingsands(), new Moves.Shadowclaw(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Uproar() };
		public override int Weight => 9500;
		public override int ExpYield => 335;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}