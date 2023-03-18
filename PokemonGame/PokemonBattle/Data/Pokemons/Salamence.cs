using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Salamence : Pokemon
	{
		public override string Name => "Salamence";
		public override List<Ability> AvailableAbilities => new() {new Intimidate() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Moxie() };
		public override Stats BaseStats => new Stats(95, 135, 80, 110, 80, 100);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Fly() },
			[1] = new List<Move>() { new Fly(), new Protect(), new Dragontail(), new Ember(), new Leer(), new Bite(), new Dragonbreath() },
			[15] = new List<Move>() { new Headbutt() },
			[20] = new List<Move>() { new Scaryface() },
			[25] = new List<Move>() { new Crunch() },
			[33] = new List<Move>() { new Dragonclaw() },
			[39] = new List<Move>() { new Zenheadbutt() },
			[46] = new List<Move>() { new Focusenergy() },
			[55] = new List<Move>() { new Flamethrower() },
			[64] = new List<Move>() { new Outrage() },
			[73] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Airslash(), new Attract(), new Bodyslam(), new Breakingswipe(), new Brickbreak(), new Brutalswing(), new Bulldoze(), new Crunch(), new Cut(), new Defog(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Dualwingbeat(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Flamethrower(), new Fly(), new Focusenergy(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Irondefense(), new Irontail(), new Outrage(), new Protect(), new Raindance(), new Rest(), new Roar(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roost(), new Round(), new Scaryface(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Steelwing(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunderfang(), new Zenheadbutt() };
		public override int Weight => 1026;
		public override int ExpYield => 300;
		public override int CatchRate => 45;
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