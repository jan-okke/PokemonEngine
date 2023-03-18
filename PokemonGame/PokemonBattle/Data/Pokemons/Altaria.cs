using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Altaria : Pokemon
	{
		public override string Name => "Altaria";
		public override List<Ability> AvailableAbilities => new() {new Naturalcure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Cloudnine() };
		public override Stats BaseStats => new Stats(75, 70, 90, 70, 105, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Dragonpulse() },
			[1] = new List<Move>() { new Hurricane(), new Dragonpulse(), new Pluck(), new Peck(), new Growl(), new Disarmingvoice(), new Mist() },
			[12] = new List<Move>() { new Furyattack() },
			[16] = new List<Move>() { new Round() },
			[20] = new List<Move>() { new Dragonbreath() },
			[24] = new List<Move>() { new Safeguard() },
			[28] = new List<Move>() { new Sing() },
			[32] = new List<Move>() { new Cottonguard() },
			[38] = new List<Move>() { new Takedown() },
			[44] = new List<Move>() { new Moonblast() },
			[50] = new List<Move>() { new Perishsong() },
			[56] = new List<Move>() { new Skyattack() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Agility(), new Attract(), new Bodyslam(), new Breakingswipe(), new Bulldoze(), new Dazzlinggleam(), new Doubleteam(), new Dracometeor(), new Dragonclaw(), new Dragondance(), new Dragonpulse(), new Dreameater(), new Dualwingbeat(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fireblast(), new Firespin(), new Flamethrower(), new Fly(), new Gigaimpact(), new Heatwave(), new Hiddenpower(), new Hurricane(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Irontail(), new Outrage(), new Playrough(), new Pluck(), new Powerswap(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Roar(), new Rocksmash(), new Roost(), new Round(), new Safeguard(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thief(), new Uproar(), new Wonderroom() };
		public override int Weight => 206;
		public override int ExpYield => 172;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}