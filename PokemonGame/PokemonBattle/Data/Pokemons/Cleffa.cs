using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cleffa : Pokemon
	{
		public override string Name => "Cleffa";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Cutecharm(), new Abilities.Magicguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Friendguard() };
		public override Stats BaseStats => new Stats(50, 25, 28, 45, 55, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Splash(), new Moves.Pound(), new Moves.Copycat() },
			[4] = new List<Move>() { new Moves.Sing() },
			[8] = new List<Move>() { new Moves.Sweetkiss() },
			[12] = new List<Move>() { new Moves.Disarmingvoice() },
			[16] = new List<Move>() { new Moves.Encore() },
			[20] = new List<Move>() { new Moves.Charm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Bodyslam(), new Moves.Charm(), new Moves.Dig(), new Moves.Doubleteam(), new Moves.Drainingkiss(), new Moves.Dreameater(), new Moves.Encore(), new Moves.Endure(), new Moves.Facade(), new Moves.Faketears(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Flash(), new Moves.Fling(), new Moves.Grassknot(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hypervoice(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Lightscreen(), new Moves.Magicalleaf(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Mistyterrain(), new Moves.Playrough(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Thunderwave(), new Moves.Trick(), new Moves.Uproar(), new Moves.Waterpulse(), new Moves.Wonderroom(), new Moves.Workup(), new Moves.Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Aromatherapy(), new Moves.Bellydrum(), new Moves.Covet(), new Moves.Faketears(), new Moves.Healpulse(), new Moves.Metronome(), new Moves.Mimic(), new Moves.Mistyterrain(), new Moves.Present(), new Moves.Splash(), new Moves.Storedpower(), new Moves.Tickle(), new Moves.Wish() };
		public override int Weight => 30;
		public override int ExpYield => 44;
		public override int CatchRate => 150;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}