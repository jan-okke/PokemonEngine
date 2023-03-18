using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Aerodactyl : Pokemon
	{
		public override string Name => "Aerodactyl";
		public override List<Ability> AvailableAbilities => new() {new Rockhead(), new Pressure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Unnerve() };
		public override Stats BaseStats => new Stats(80, 105, 65, 60, 75, 130);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Bite(), new Ancientpower() },
			[5] = new List<Move>() { new Supersonic() },
			[10] = new List<Move>() { new Wingattack() },
			[15] = new List<Move>() { new Scaryface() },
			[20] = new List<Move>() { new Rockslide() },
			[25] = new List<Move>() { new Roar() },
			[30] = new List<Move>() { new Crunch() },
			[35] = new List<Move>() { new Ironhead() },
			[40] = new List<Move>() { new Takedown() },
			[45] = new List<Move>() { new Stoneedge() },
			[50] = new List<Move>() { new Agility() },
			[55] = new List<Move>() { new Hyperbeam() },
			[60] = new List<Move>() { new Gigaimpact() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Assurance(), new Attract(), new Brutalswing(), new Bulldoze(), new Crunch(), new Defog(), new Doubleteam(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Dualwingbeat(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Fireblast(), new Firefang(), new Flamethrower(), new Fly(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Icefang(), new Ironhead(), new Irontail(), new Meteorbeam(), new Payback(), new Protect(), new Psychicfangs(), new Raindance(), new Rest(), new Roar(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roost(), new Round(), new Sandstorm(), new Scaryface(), new Sleeptalk(), new Snore(), new Stealthrock(), new Steelwing(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Taunt(), new Thief(), new Thunderfang(), new Torment() };
		public override List<Move> EggMoves => new List<Move>() { new Assurance(), new Curse(), new Dragonbreath(), new Tailwind(), new Whirlwind(), new Wideguard() };
		public override int Weight => 590;
		public override int ExpYield => 180;
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