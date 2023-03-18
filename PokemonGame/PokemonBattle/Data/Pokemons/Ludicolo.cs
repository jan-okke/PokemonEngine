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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Swiftswim(), new Abilities.Raindish() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Owntempo() };
		public override Stats BaseStats => new Stats(80, 70, 70, 90, 100, 70);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Teeterdance(), new Moves.Fakeout(), new Moves.Knockoff(), new Moves.Flail(), new Moves.Mist(), new Moves.Megadrain(), new Moves.Furyswipes(), new Moves.Bubblebeam(), new Moves.Naturepower(), new Moves.Gigadrain(), new Moves.Raindance(), new Moves.Zenheadbutt(), new Moves.Energyball(), new Moves.Hydropump(), new Moves.Astonish(), new Moves.Growl(), new Moves.Absorb(), new Moves.Watergun() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Amnesia(), new Moves.Attract(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Brickbreak(), new Moves.Bulletseed(), new Moves.Dive(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Encore(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Hail(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Hyperbeam(), new Moves.Hypervoice(), new Moves.Icebeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Leafstorm(), new Moves.Megakick(), new Moves.Megapunch(), new Moves.Metronome(), new Moves.Muddywater(), new Moves.Mudshot(), new Moves.Protect(), new Moves.Raindance(), new Moves.Rest(), new Moves.Rockclimb(), new Moves.Rocksmash(), new Moves.Round(), new Moves.Scald(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Strength(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Surf(), new Moves.Swagger(), new Moves.Swordsdance(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Uproar(), new Moves.Waterfall(), new Moves.Waterpulse(), new Moves.Weatherball(), new Moves.Whirlpool(), new Moves.Zenheadbutt() };
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