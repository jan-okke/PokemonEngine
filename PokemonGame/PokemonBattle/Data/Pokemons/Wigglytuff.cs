using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Wigglytuff : Pokemon
	{
		public override string Name => "Wigglytuff";
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Frisk() };
		public override Stats BaseStats => new Stats(140, 70, 45, 85, 50, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Sweetkiss(), new Disarmingvoice(), new Disable(), new Charm(), new Echoedvoice(), new Covet(), new Stockpile(), new Swallow(), new Spitup(), new Round(), new Rest(), new Bodyslam(), new Mimic(), new Gyroball(), new Playrough(), new Hypervoice(), new Doubleedge(), new Sing(), new Pound(), new Copycat(), new Defensecurl() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Batonpass(), new Blizzard(), new Bodyslam(), new Bounce(), new Brickbreak(), new Chargebeam(), new Charm(), new Dazzlinggleam(), new Dig(), new Doubleteam(), new Drainingkiss(), new Drainpunch(), new Dreameater(), new Endure(), new Expandingforce(), new Facade(), new Faketears(), new Fireblast(), new Firepunch(), new Flamethrower(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Gigaimpact(), new Grassknot(), new Gyroball(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Lightscreen(), new Magicroom(), new Megakick(), new Megapunch(), new Mistyexplosion(), new Mistyterrain(), new Playrough(), new Protect(), new Psychic(), new Psychup(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Retaliate(), new Round(), new Safeguard(), new Screech(), new Selfdestruct(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stealthrock(), new Steelroller(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Triattack(), new Uproar(), new Waterpulse(), new Wildcharge(), new Workup() };
		public override int Weight => 120;
		public override int ExpYield => 218;
		public override int CatchRate => 50;
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