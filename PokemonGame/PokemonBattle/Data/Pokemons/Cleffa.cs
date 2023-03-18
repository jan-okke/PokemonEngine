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
		public override List<Ability> AvailableAbilities => new() {new Cutecharm(), new Magicguard() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Friendguard() };
		public override Stats BaseStats => new Stats(50, 25, 28, 45, 55, 15);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Splash(), new Pound(), new Copycat() },
			[4] = new List<Move>() { new Sing() },
			[8] = new List<Move>() { new Sweetkiss() },
			[12] = new List<Move>() { new Disarmingvoice() },
			[16] = new List<Move>() { new Encore() },
			[20] = new List<Move>() { new Charm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodyslam(), new Charm(), new Dig(), new Doubleteam(), new Drainingkiss(), new Dreameater(), new Encore(), new Endure(), new Facade(), new Faketears(), new Fireblast(), new Flamethrower(), new Flash(), new Fling(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Icywind(), new Irontail(), new Lightscreen(), new Magicalleaf(), new Megakick(), new Megapunch(), new Metronome(), new Mistyterrain(), new Playrough(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Thunderwave(), new Trick(), new Uproar(), new Waterpulse(), new Wonderroom(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Amnesia(), new Aromatherapy(), new Bellydrum(), new Covet(), new Faketears(), new Healpulse(), new Metronome(), new Mimic(), new Mistyterrain(), new Present(), new Splash(), new Storedpower(), new Tickle(), new Wish() };
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