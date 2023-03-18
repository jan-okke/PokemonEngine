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
		public override List<Ability> AvailableAbilities => new() {new Drought() };
		public override Stats BaseStats => new Stats(100, 150, 140, 100, 90, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ground };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Mudshot(), new Ancientpower(), new Lavaplume(), new Scaryface() },
			[9] = new List<Move>() { new Earthpower() },
			[18] = new List<Move>() { new Bulkup() },
			[27] = new List<Move>() { new Earthquake() },
			[36] = new List<Move>() { new Hammerarm() },
			[45] = new List<Move>() { new Fissure() },
			[54] = new List<Move>() { new Rest() },
			[63] = new List<Move>() { new Precipiceblades() },
			[72] = new List<Move>() { new Fireblast() },
			[81] = new List<Move>() { new Solarbeam() },
			[90] = new List<Move>() { new Eruption() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Bodyslam(), new Brickbreak(), new Brutalswing(), new Bulkup(), new Bulldoze(), new Cut(), new Dig(), new Doubleteam(), new Dragonclaw(), new Dragonpulse(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firepunch(), new Flamethrower(), new Fling(), new Focusblast(), new Gigaimpact(), new Heatcrash(), new Heavyslam(), new Hiddenpower(), new Highhorsepower(), new Hyperbeam(), new Ironhead(), new Irontail(), new Megakick(), new Megapunch(), new Mudshot(), new Overheat(), new Protect(), new Psychup(), new Rest(), new Roar(), new Rockclimb(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Scaryface(), new Scorchingsands(), new Shadowclaw(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Uproar() };
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