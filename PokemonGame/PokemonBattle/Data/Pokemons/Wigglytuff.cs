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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Cutecharm(), new Abilities.Competitive() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Frisk() };
		public override Stats BaseStats => new Stats(140, 70, 45, 85, 50, 45);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Sweetkiss(), new Moves.Disarmingvoice(), new Moves.Disable(), new Moves.Charm(), new Moves.Echoedvoice(), new Moves.Covet(), new Moves.Stockpile(), new Moves.Swallow(), new Moves.Spitup(), new Moves.Round(), new Moves.Rest(), new Moves.Bodyslam(), new Moves.Mimic(), new Moves.Gyroball(), new Moves.Playrough(), new Moves.Hypervoice(), new Moves.Doubleedge(), new Moves.Sing(), new Moves.Pound(), new Moves.Copycat(), new Moves.Defensecurl() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Chargebeam(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Expandingforce(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fireblast(), new Moves.Firepunch(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Mistyexplosion(), new Moves.Mistyterrain(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Retaliate(), new Moves.Round(), new Moves.Safeguard(), new Moves.Screech(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Stealthrock(), new Moves.Steelroller(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunder(), new Moves.Thunderbolt(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Triattack(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Wildcharge(), new Moves.Workup() };
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