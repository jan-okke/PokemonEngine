using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Togekiss : Pokemon
	{
		public override string Name => "Togekiss";
		public override List<Ability> AvailableAbilities => new() {new Hustle(), new Serenegrace() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Superluck() };
		public override Stats BaseStats => new Stats(85, 50, 95, 80, 120, 115);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Fairy, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Airslash() },
			[1] = new List<Move>() { new Airslash(), new Fairywind(), new Skyattack(), new Aurasphere(), new Extremespeed(), new Triattack(), new Charm(), new Ancientpower(), new Yawn(), new Metronome(), new Afteryou(), new Doubleedge(), new Safeguard(), new Followme(), new Batonpass(), new Lastresort(), new Wish(), new Growl(), new Pound(), new Sweetkiss(), new Lifedew() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Airslash(), new Allyswitch(), new Amnesia(), new Attract(), new Aurasphere(), new Batonpass(), new Bodyslam(), new Brickbreak(), new Charm(), new Dazzlinggleam(), new Defog(), new Doubleteam(), new Drainingkiss(), new Drainpunch(), new Dreameater(), new Dualwingbeat(), new Encore(), new Endure(), new Facade(), new Fireblast(), new Flamethrower(), new Flash(), new Fling(), new Fly(), new Focuspunch(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Heatwave(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Imprison(), new Lightscreen(), new Magicalleaf(), new Megakick(), new Megapunch(), new Metronome(), new Mysticalfire(), new Nastyplot(), new Playrough(), new Pluck(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Reflect(), new Rest(), new Retaliate(), new Rocksmash(), new Roost(), new Round(), new Safeguard(), new Shadowball(), new Shockwave(), new Sleeptalk(), new Smartstrike(), new Snore(), new Solarbeam(), new Steelwing(), new Storedpower(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Thunderwave(), new Triattack(), new Trick(), new Uproar(), new Waterpulse(), new Workup(), new Zenheadbutt() };
		public override int Weight => 380;
		public override int ExpYield => 273;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}