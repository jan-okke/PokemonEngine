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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Naturalcure() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Cloudnine() };
		public override Stats BaseStats => new Stats(75, 70, 90, 70, 105, 80);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Dragon, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Moves.Dragonpulse() },
			[1] = new List<Move>() { new Moves.Hurricane(), new Moves.Dragonpulse(), new Moves.Pluck(), new Moves.Peck(), new Moves.Growl(), new Moves.Disarmingvoice(), new Moves.Mist() },
			[12] = new List<Move>() { new Moves.Furyattack() },
			[16] = new List<Move>() { new Moves.Round() },
			[20] = new List<Move>() { new Moves.Dragonbreath() },
			[24] = new List<Move>() { new Moves.Safeguard() },
			[28] = new List<Move>() { new Moves.Sing() },
			[32] = new List<Move>() { new Moves.Cottonguard() },
			[38] = new List<Move>() { new Moves.Takedown() },
			[44] = new List<Move>() { new Moves.Moonblast() },
			[50] = new List<Move>() { new Moves.Perishsong() },
			[56] = new List<Move>() { new Moves.Skyattack() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Aerialace(), new Moves.Agility(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Breakingswipe(), new Moves.Bulldoze(), new Moves.Dazzlinggleam(), new Moves.Doubleteam(), new Moves.Dracometeor(), new Moves.Dragonclaw(), new Moves.Dragondance(), new Moves.Dragonpulse(), new Moves.Dreameater(), new Moves.Dualwingbeat(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Facade(), new Moves.Falseswipe(), new Moves.Fireblast(), new Moves.Firespin(), new Moves.Flamethrower(), new Moves.Fly(), new Moves.Gigaimpact(), new Moves.Heatwave(), new Moves.Hiddenpower(), new Moves.Hurricane(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Irontail(), new Moves.Outrage(), new Moves.Playrough(), new Moves.Pluck(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Rest(), new Moves.Roar(), new Moves.Rocksmash(), new Moves.Roost(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Steelwing(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Swift(), new Moves.Thief(), new Moves.Uproar(), new Moves.Wonderroom() };
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