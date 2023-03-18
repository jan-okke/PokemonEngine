using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Togepi : Pokemon
	{
		public override string Name => "Togepi";
		public override List<Ability> AvailableAbilities => new() {new Hustle(), new Serenegrace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Superluck() };
		public override Stats BaseStats => new Stats(35, 20, 65, 40, 65, 20);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Growl(), new Pound() },
			[4] = new List<Move>() { new Sweetkiss() },
			[8] = new List<Move>() { new Lifedew() },
			[12] = new List<Move>() { new Charm() },
			[16] = new List<Move>() { new Ancientpower() },
			[20] = new List<Move>() { new Yawn() },
			[24] = new List<Move>() { new Metronome() },
			[28] = new List<Move>() { new Afteryou() },
			[32] = new List<Move>() { new Doubleedge() },
			[36] = new List<Move>() { new Safeguard() },
			[40] = new List<Move>() { new Followme() },
			[44] = new List<Move>() { new Batonpass() },
			[48] = new List<Move>() { new Lastresort() },
			[52] = new List<Move>() { new Wish() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Batonpass(), new Bodyslam(), new Charm(), new Dazzlinggleam(), new Doubleteam(), new Drainingkiss(), new Dreameater(), new Encore(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Flash(), new Fling(), new Futuresight(), new Grassknot(), new Helpinghand(), new Hiddenpower(), new Hypervoice(), new Lightscreen(), new Megakick(), new Megapunch(), new Metronome(), new Mysticalfire(), new Nastyplot(), new Playrough(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Rocksmash(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Snore(), new Solarbeam(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunderwave(), new Triattack(), new Trick(), new Uproar(), new Waterpulse(), new Workup(), new Zenheadbutt() };
		public override List<Move> EggMoves => new List<Move>() { new Extrasensory(), new Futuresight(), new Morningsun(), new Peck(), new Present(), new Psychoshift(), new Storedpower() };
		public override int Weight => 15;
		public override int ExpYield => 49;
		public override int CatchRate => 190;
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