using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Togetic : Pokemon
	{
		public override string Name => "Togetic";
		public override List<Ability> AvailableAbilities => new() {new Hustle(), new Serenegrace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Superluck() };
		public override Stats BaseStats => new Stats(55, 40, 85, 80, 105, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Fairywind() },
			[1] = new List<Move>() { new Fairywind(), new Growl(), new Pound(), new Sweetkiss(), new Lifedew() },
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
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Batonpass(), new Bodyslam(), new Brickbreak(), new Charm(), new Dazzlinggleam(), new Defog(), new Doubleteam(), new Drainingkiss(), new Drainpunch(), new Dreameater(), new Dualwingbeat(), new Encore(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Flash(), new Fling(), new Fly(), new Focuspunch(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Imprison(), new Lightscreen(), new Magicalleaf(), new Megakick(), new Megapunch(), new Metronome(), new Mysticalfire(), new Nastyplot(), new Playrough(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Rocksmash(), new Roost(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Smartstrike(), new Snore(), new Solarbeam(), new Steelwing(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunderwave(), new Triattack(), new Trick(), new Uproar(), new Waterpulse(), new Workup(), new Zenheadbutt() };
		public override int Weight => 32;
		public override int ExpYield => 142;
		public override int CatchRate => 75;
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