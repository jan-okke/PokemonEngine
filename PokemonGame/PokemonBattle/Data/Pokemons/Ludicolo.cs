using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Ludicolo : Pokemon
	{
		public override string Name => "Ludicolo";
		public override List<Ability> AvailableAbilities => new() {new Swiftswim(), new Raindish() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Owntempo() };
		public override Stats BaseStats => new Stats(80, 70, 70, 90, 100, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Teeterdance(), new Fakeout(), new Knockoff(), new Flail(), new Mist(), new Megadrain(), new Furyswipes(), new Bubblebeam(), new Naturepower(), new Gigadrain(), new Raindance(), new Zenheadbutt(), new Energyball(), new Hydropump(), new Astonish(), new Growl(), new Absorb(), new Watergun() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Blizzard(), new Bodyslam(), new Brickbreak(), new Bulletseed(), new Dive(), new Doubleteam(), new Drainpunch(), new Encore(), new Endure(), new Energyball(), new Facade(), new Firepunch(), new Flash(), new Fling(), new Focusblast(), new Focuspunch(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Hail(), new Hiddenpower(), new Hydropump(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Icepunch(), new Icywind(), new Leafstorm(), new Megakick(), new Megapunch(), new Metronome(), new Muddywater(), new Mudshot(), new Protect(), new Raindance(), new Rest(), new Rockclimb(), new Rocksmash(), new Round(), new Scald(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Strength(), new Substitute(), new Sunnyday(), new Surf(), new Swagger(), new Swordsdance(), new Thief(), new Thunderpunch(), new Uproar(), new Waterfall(), new Waterpulse(), new Weatherball(), new Whirlpool(), new Zenheadbutt() };
		public override int Weight => 550;
		public override int ExpYield => 240;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 3,
			[Stat.Speed] = 0
		};
	}
}