using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Jigglypuff : Pokemon
	{
		public override string Name => "Jigglypuff";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Friendguard() };
		public override Stats BaseStats => new Stats(115, 45, 20, 45, 25, 20);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sweetkiss(), new Disarmingvoice(), new Disable(), new Charm(), new Sing(), new Pound(), new Copycat(), new Defensecurl() },
			[4] = new List<Move>() { new Echoedvoice() },
			[8] = new List<Move>() { new Covet() },
			[12] = new List<Move>() { new Stockpile(), new Swallow(), new Spitup() },
			[16] = new List<Move>() { new Round() },
			[20] = new List<Move>() { new Rest() },
			[24] = new List<Move>() { new Bodyslam() },
			[28] = new List<Move>() { new Mimic() },
			[32] = new List<Move>() { new Gyroball() },
			[36] = new List<Move>() { new Hypervoice() },
			[40] = new List<Move>() { new Playrough() },
			[44] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Batonpass(), new Blizzard(), new Bodyslam(), new Bounce(), new Brickbreak(), new Chargebeam(), new Charm(), new Dazzlinggleam(), new Dig(), new Doubleteam(), new Drainingkiss(), new Drainpunch(), new Dreameater(), new Endure(), new Facade(), new Faketears(), new Fireblast(), new Firepunch(), new Flamethrower(), new Flash(), new Fling(), new Focuspunch(), new Grassknot(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Lightscreen(), new Megakick(), new Megapunch(), new Mistyexplosion(), new Mistyterrain(), new Playrough(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Retaliate(), new Round(), new Safeguard(), new Screech(), new Selfdestruct(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Steelroller(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Triattack(), new Uproar(), new Waterpulse(), new Wildcharge(), new Workup() };
		public override int Weight => 55;
		public override int ExpYield => 95;
		public override int CatchRate => 170;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 2,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}